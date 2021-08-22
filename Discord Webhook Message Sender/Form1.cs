using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Discord_Webhook_Message_Sender
{
    public partial class Form1 : Form
    {
        string avatarurl;
        string webhook;
        string username;
        string messagea;
        string messageb;
        string messagec;
        string messaged;
        string messageg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webhook = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static void sendDiscordWebhook(string URL, string profilepic, string username, string message)
            {

                NameValueCollection discordValues = new NameValueCollection();
                discordValues.Add("username", username);
                discordValues.Add("avatar_url", profilepic);
                discordValues.Add("content", message);
                new WebClient().UploadValues(URL, discordValues);
            }
            if (webhook.Length < 10)
            {
                MessageBox.Show("Invalid WebHook URL");
            }
            else if (avatarurl.Length < 4 && avatarurl.Length != 0)
            {
                MessageBox.Show("Invalid Avatar URL");
            }
            else if (username.Length == 0)
            {
                sendDiscordWebhook(webhook, avatarurl, username, messagea + "\n" + messageb + "\n" + messagec + "\n" + messaged + "\n" + messageg);
            }
            else if (username.Length > 0)
            {
                sendDiscordWebhook(webhook, avatarurl, username, messagea + "\n" + messageb + "\n" + messagec + "\n" + messaged + "\n" + messageg);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            avatarurl = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            username = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            messagea = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            messageb = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            messagec = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            messaged = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            messageg = textBox8.Text;
        }
    }
}
