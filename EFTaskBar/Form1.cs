using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTaskBar
{
    public partial class Form1 : Form
    {
        TaskToDo model = new TaskToDo();
        public Form1()
        {
            InitializeComponent();

            var timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick_ValueChanged;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        void Clear()
        {
            todoList.Clear();
        }

        private void todoList_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            model.Task = todoList.Text.Trim();
            using(TodoDataEntities db = new TodoDataEntities())
            {
                db.TaskToDoes.Add(model);
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Aufgabe wurde hinzugefügt");
        }

        void ShowTodoList()
        {

            using(TodoDataEntities db = new TodoDataEntities())
            {
                var display = string.Empty;
                foreach(var p in db.TaskToDoes.Where(c => c.Done == false))
                {
                    display += $"\n{p.Task}";
                }
                MessageBox.Show(display);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTodoList();
        }

        private void Timer_Tick_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
