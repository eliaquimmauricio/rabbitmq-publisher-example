using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Concurrent;
using System.Text;
using System.Windows.Forms;

namespace RabbitMq.Publisher.Example
{
    public partial class Form1 : Form
    {
        private IModel _channel;

        private readonly  string _correlationId = Guid.NewGuid().ToString();
        
        delegate void ReceveidMessageHandler(string msg);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            //Criando o canal de comunicação com o RabbitMQ.

            _channel = new ConnectionFactory { HostName = txtServer.Text }.CreateConnection()
                                                                          .CreateModel();

            //Declarando a fila que será utilizada, caso não exista com esse nome ele irá criar automaticamente.

            _channel.QueueDeclare(txtQueueName.Text, false, false, true, null);

            _channel.QueueDeclare(txtReturnQueueName.Text, false, false, true, null);

            //Declarando um consumidor para rastrear todas as mensagem recebidas na fila.

            EventingBasicConsumer consumer = new EventingBasicConsumer(_channel);
            consumer.Received += ReceivedText;

            _channel.BasicConsume(consumer, txtQueueName.Text, true);

            btnConect.Enabled = false;
        }

        private void ReceivedText(object model, BasicDeliverEventArgs ea)
        {
            if (ea.BasicProperties.CorrelationId != _correlationId)
                return;

            AddMessage(Encoding.UTF8.GetString(ea.Body));            
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            if (btnConect.Enabled)
                return;

            byte[] messageBytes = Encoding.UTF8.GetBytes(txtSendText.Text);

            IBasicProperties properties = _channel.CreateBasicProperties();
            properties.CorrelationId = _correlationId;
            properties.ReplyTo = txtQueueName.Text;
            
            _channel.BasicPublish(string.Empty, txtReturnQueueName.Text, properties, messageBytes);

            AddMessage("Texto adicionado a fila.");
        }

        void AddMessage(string msg)
        {
            if (InvokeRequired)
            {
                ReceveidMessageHandler callback = AddMessage;
                Invoke(callback, msg);
                return;
            }

            txtReceveidText.Text += ">>> " + msg + Environment.NewLine;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
