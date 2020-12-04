using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EFTaskBar
{
    public partial class Form1 : Form
    {
        
        TaskToDo model = new TaskToDo();
        
        public Form1()
        {
            InitializeComponent();

            string deateTimeFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = deateTimeFormat;

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
            
            dateTimePicker1.Value = DateTime.Now;

            model.Task = todoList.Text.Trim();
            model.TimeStemp = dateTimePicker1.Value;
           
            using (TodoDataEntities db = new TodoDataEntities())
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
                    display += $"\n{p.Task} + {p.Done}";
                }
                MessageBox.Show(display);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTodoList();
        }

        private void btnShowDbRtb_Click(object sender, EventArgs e)
        {
            ShowDbInsRbt();   
        }

        void ShowDbInsRbt()
        {
             using(TodoDataEntities db = new TodoDataEntities())
            {
                var display = string.Empty;
                foreach(var p in db.TaskToDoes.Where(c => c.Done == false))
                {
                    display += $"\n{p.Task} + {p.Done} + {p.TimeStemp}";
                }
                todoList.Text = display.ToString();
            }
        }
    }
}
