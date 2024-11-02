
namespace домашнее_задание
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCreateDocument = new System.Windows.Forms.Button();
            this.TextBoxGeneral = new System.Windows.Forms.TextBox();
            this.ButtonMoveTextToWindow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonEncryptText = new System.Windows.Forms.Button();
            this.ButtonMoveTextToFile = new System.Windows.Forms.Button();
            this.ButtonDemoDecrypt = new System.Windows.Forms.Button();
            this.TextBoxDemoStart = new System.Windows.Forms.TextBox();
            this.TextBoxDemoFinish = new System.Windows.Forms.TextBox();
            this.ButtonDecryptText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1168, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курсовая работа Владюши Овсянникова =)";
            // 
            // ButtonCreateDocument
            // 
            this.ButtonCreateDocument.Location = new System.Drawing.Point(12, 168);
            this.ButtonCreateDocument.Name = "ButtonCreateDocument";
            this.ButtonCreateDocument.Size = new System.Drawing.Size(243, 23);
            this.ButtonCreateDocument.TabIndex = 1;
            this.ButtonCreateDocument.Text = "Выбрать/Создать текстовый документ";
            this.ButtonCreateDocument.UseVisualStyleBackColor = true;
            this.ButtonCreateDocument.Click += new System.EventHandler(this.ButtonCreateDocumentClick);
            // 
            // TextBoxGeneral
            // 
            this.TextBoxGeneral.Location = new System.Drawing.Point(429, 103);
            this.TextBoxGeneral.Multiline = true;
            this.TextBoxGeneral.Name = "TextBoxGeneral";
            this.TextBoxGeneral.Size = new System.Drawing.Size(362, 200);
            this.TextBoxGeneral.TabIndex = 2;
            // 
            // ButtonMoveTextToWindow
            // 
            this.ButtonMoveTextToWindow.Location = new System.Drawing.Point(12, 197);
            this.ButtonMoveTextToWindow.Name = "ButtonMoveTextToWindow";
            this.ButtonMoveTextToWindow.Size = new System.Drawing.Size(243, 23);
            this.ButtonMoveTextToWindow.TabIndex = 3;
            this.ButtonMoveTextToWindow.Text = "Перенести текст из документа в окно";
            this.ButtonMoveTextToWindow.UseVisualStyleBackColor = true;
            this.ButtonMoveTextToWindow.Click += new System.EventHandler(this.ButtonMoveTextToWindowClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Создаёт на рабочем столе текстовый документ с файлом \"Курсовая работа.txt\"";
            // 
            // ButtonEncryptText
            // 
            this.ButtonEncryptText.Location = new System.Drawing.Point(13, 226);
            this.ButtonEncryptText.Name = "ButtonEncryptText";
            this.ButtonEncryptText.Size = new System.Drawing.Size(242, 23);
            this.ButtonEncryptText.TabIndex = 5;
            this.ButtonEncryptText.Text = "Зашифровать текст";
            this.ButtonEncryptText.UseVisualStyleBackColor = true;
            this.ButtonEncryptText.Click += new System.EventHandler(this.ButtonEncryptTextClick);
            // 
            // ButtonMoveTextToFile
            // 
            this.ButtonMoveTextToFile.Location = new System.Drawing.Point(12, 284);
            this.ButtonMoveTextToFile.Name = "ButtonMoveTextToFile";
            this.ButtonMoveTextToFile.Size = new System.Drawing.Size(243, 23);
            this.ButtonMoveTextToFile.TabIndex = 6;
            this.ButtonMoveTextToFile.Text = "Перенести текст из окна в файл";
            this.ButtonMoveTextToFile.UseVisualStyleBackColor = true;
            this.ButtonMoveTextToFile.Click += new System.EventHandler(this.ButtonMoveTextToFileClick);
            // 
            // ButtonDemoDecrypt
            // 
            this.ButtonDemoDecrypt.Location = new System.Drawing.Point(651, 508);
            this.ButtonDemoDecrypt.Name = "ButtonDemoDecrypt";
            this.ButtonDemoDecrypt.Size = new System.Drawing.Size(128, 23);
            this.ButtonDemoDecrypt.TabIndex = 7;
            this.ButtonDemoDecrypt.Text = "Перевести";
            this.ButtonDemoDecrypt.UseVisualStyleBackColor = true;
            this.ButtonDemoDecrypt.Click += new System.EventHandler(this.ButtonDemoDecryptCkick);
            // 
            // TextBoxDemoStart
            // 
            this.TextBoxDemoStart.Location = new System.Drawing.Point(554, 432);
            this.TextBoxDemoStart.Multiline = true;
            this.TextBoxDemoStart.Name = "TextBoxDemoStart";
            this.TextBoxDemoStart.Size = new System.Drawing.Size(142, 50);
            this.TextBoxDemoStart.TabIndex = 8;
            // 
            // TextBoxDemoFinish
            // 
            this.TextBoxDemoFinish.Location = new System.Drawing.Point(729, 432);
            this.TextBoxDemoFinish.Multiline = true;
            this.TextBoxDemoFinish.Name = "TextBoxDemoFinish";
            this.TextBoxDemoFinish.Size = new System.Drawing.Size(162, 50);
            this.TextBoxDemoFinish.TabIndex = 9;
            // 
            // ButtonDecryptText
            // 
            this.ButtonDecryptText.Location = new System.Drawing.Point(12, 255);
            this.ButtonDecryptText.Name = "ButtonDecryptText";
            this.ButtonDecryptText.Size = new System.Drawing.Size(243, 23);
            this.ButtonDecryptText.TabIndex = 10;
            this.ButtonDecryptText.Text = "Дешифровать текст";
            this.ButtonDecryptText.UseVisualStyleBackColor = true;
            this.ButtonDecryptText.Click += new System.EventHandler(this.ButtonDecryptTextClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 543);
            this.Controls.Add(this.ButtonDecryptText);
            this.Controls.Add(this.TextBoxDemoFinish);
            this.Controls.Add(this.TextBoxDemoStart);
            this.Controls.Add(this.ButtonDemoDecrypt);
            this.Controls.Add(this.ButtonMoveTextToFile);
            this.Controls.Add(this.ButtonEncryptText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonMoveTextToWindow);
            this.Controls.Add(this.TextBoxGeneral);
            this.Controls.Add(this.ButtonCreateDocument);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCreateDocument;
        private System.Windows.Forms.TextBox TextBoxGeneral;
        private System.Windows.Forms.Button ButtonMoveTextToWindow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonEncryptText;
        private System.Windows.Forms.Button ButtonMoveTextToFile;
        private System.Windows.Forms.Button ButtonDemoDecrypt;
        private System.Windows.Forms.TextBox TextBoxDemoStart;
        private System.Windows.Forms.TextBox TextBoxDemoFinish;
        private System.Windows.Forms.Button ButtonDecryptText;
    }
}

