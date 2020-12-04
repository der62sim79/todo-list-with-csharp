
namespace EFTaskBar
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.todoList = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShowDbRtb = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // todoList
            // 
            this.todoList.Location = new System.Drawing.Point(80, 95);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(442, 294);
            this.todoList.TabIndex = 3;
            this.todoList.Text = "";
            this.todoList.TextChanged += new System.EventHandler(this.todoList_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Todo  Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnShowDbRtb
            // 
            this.btnShowDbRtb.Location = new System.Drawing.Point(544, 348);
            this.btnShowDbRtb.Name = "btnShowDbRtb";
            this.btnShowDbRtb.Size = new System.Drawing.Size(244, 23);
            this.btnShowDbRtb.TabIndex = 8;
            this.btnShowDbRtb.Text = "Anzeige im RichBoxText";
            this.btnShowDbRtb.UseVisualStyleBackColor = true;
            this.btnShowDbRtb.Click += new System.EventHandler(this.btnShowDbRtb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowDbRtb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todoList);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox todoList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShowDbRtb;
        private System.Windows.Forms.Timer timer1;
    }
}

