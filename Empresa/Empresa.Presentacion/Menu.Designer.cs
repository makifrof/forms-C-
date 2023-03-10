using System;
using System.Windows.Forms;

namespace Empresa.Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnSalarioMN = new System.Windows.Forms.Button();
            this.btnSalarioMD = new System.Windows.Forms.Button();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.btnTotalE = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.lbSeguro = new System.Windows.Forms.Label();
            this.chkTemporal = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.chkEmpV = new System.Windows.Forms.CheckBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEmpD = new System.Windows.Forms.CheckBox();
            this.chkEmpN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEmpleadosD = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpN = new System.Windows.Forms.Button();
            this.btnEliminarEmpD = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gridEmpleadosN = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVespertino = new System.Windows.Forms.Label();
            this.gridEmpleadosV = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpV = new System.Windows.Forms.Button();
            this.btnSalarioMV = new System.Windows.Forms.Button();
            this.gridEmpleadosT = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(610, 849);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(980, 120);
            this.txtInfo.TabIndex = 94;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // btnGastos
            // 
            this.btnGastos.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Location = new System.Drawing.Point(18, 845);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(294, 35);
            this.btnGastos.TabIndex = 93;
            this.btnGastos.Text = "Gastos Generales";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click_1);
            // 
            // btnSalarioMN
            // 
            this.btnSalarioMN.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMN.Location = new System.Drawing.Point(321, 889);
            this.btnSalarioMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalarioMN.Name = "btnSalarioMN";
            this.btnSalarioMN.Size = new System.Drawing.Size(266, 35);
            this.btnSalarioMN.TabIndex = 92;
            this.btnSalarioMN.Text = "Salario Mayor N";
            this.btnSalarioMN.UseVisualStyleBackColor = true;
            this.btnSalarioMN.Click += new System.EventHandler(this.btnSalarioMN_Click_1);
            // 
            // btnSalarioMD
            // 
            this.btnSalarioMD.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalarioMD.Location = new System.Drawing.Point(321, 845);
            this.btnSalarioMD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalarioMD.Name = "btnSalarioMD";
            this.btnSalarioMD.Size = new System.Drawing.Size(266, 35);
            this.btnSalarioMD.TabIndex = 91;
            this.btnSalarioMD.Text = "Salario MayorD";
            this.btnSalarioMD.UseVisualStyleBackColor = true;
            this.btnSalarioMD.Click += new System.EventHandler(this.btnSalarioMD_Click_1);
            // 
            // btnPromedios
            // 
            this.btnPromedios.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedios.Location = new System.Drawing.Point(19, 800);
            this.btnPromedios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(294, 35);
            this.btnPromedios.TabIndex = 90;
            this.btnPromedios.Text = "PromGeneral Salarios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click_1);
            // 
            // btnTotalE
            // 
            this.btnTotalE.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTotalE.Location = new System.Drawing.Point(19, 755);
            this.btnTotalE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTotalE.Name = "btnTotalE";
            this.btnTotalE.Size = new System.Drawing.Size(294, 35);
            this.btnTotalE.TabIndex = 89;
            this.btnTotalE.Text = "Cantidad TotalEmp";
            this.btnTotalE.UseVisualStyleBackColor = true;
            this.btnTotalE.Click += new System.EventHandler(this.btnTotalE_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(18, 934);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(294, 35);
            this.btnSalir.TabIndex = 88;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtSeguro);
            this.panel1.Controls.Add(this.lbSeguro);
            this.panel1.Controls.Add(this.chkTemporal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lbCelular);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.chkEmpV);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkEmpD);
            this.panel1.Controls.Add(this.chkEmpN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 624);
            this.panel1.TabIndex = 80;
            this.panel1.Tag = "";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(246, 390);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSeguro.Size = new System.Drawing.Size(277, 35);
            this.txtSeguro.TabIndex = 69;
            // 
            // lbSeguro
            // 
            this.lbSeguro.AutoSize = true;
            this.lbSeguro.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeguro.Location = new System.Drawing.Point(23, 394);
            this.lbSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeguro.Name = "lbSeguro";
            this.lbSeguro.Size = new System.Drawing.Size(157, 27);
            this.lbSeguro.TabIndex = 68;
            this.lbSeguro.Text = "No. asegurado:";
            this.lbSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTemporal
            // 
            this.chkTemporal.AutoSize = true;
            this.chkTemporal.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTemporal.Location = new System.Drawing.Point(149, 446);
            this.chkTemporal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTemporal.Name = "chkTemporal";
            this.chkTemporal.Size = new System.Drawing.Size(226, 31);
            this.chkTemporal.TabIndex = 67;
            this.chkTemporal.Text = "Empleado Temporal";
            this.chkTemporal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 27);
            this.label5.TabIndex = 66;
            this.label5.Text = "Segundo apellido:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(246, 345);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCelular.Size = new System.Drawing.Size(277, 35);
            this.txtCelular.TabIndex = 65;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(246, 300);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCorreo.Size = new System.Drawing.Size(277, 35);
            this.txtCorreo.TabIndex = 64;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(23, 349);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(86, 27);
            this.lbCelular.TabIndex = 63;
            this.lbCelular.Text = "Celular:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(23, 304);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(85, 27);
            this.lbEmail.TabIndex = 62;
            this.lbEmail.Text = "Correo:";
            // 
            // chkEmpV
            // 
            this.chkEmpV.AutoSize = true;
            this.chkEmpV.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpV.Location = new System.Drawing.Point(149, 569);
            this.chkEmpV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpV.Name = "chkEmpV";
            this.chkEmpV.Size = new System.Drawing.Size(243, 31);
            this.chkEmpV.TabIndex = 61;
            this.chkEmpV.Text = "Empleado Vespertino";
            this.chkEmpV.UseVisualStyleBackColor = true;
            this.chkEmpV.CheckedChanged += new System.EventHandler(this.ChkEmpV_CheckStateChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(246, 255);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSalario.Size = new System.Drawing.Size(277, 35);
            this.txtSalario.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 27);
            this.label10.TabIndex = 13;
            this.label10.Text = "Salario:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(246, 165);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(277, 35);
            this.txtApellido2.TabIndex = 12;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(246, 210);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(277, 35);
            this.txtCedula.TabIndex = 10;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(246, 120);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(277, 35);
            this.txtApellido1.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(246, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 35);
            this.txtNombre.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(246, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(277, 35);
            this.txtID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chkEmpD
            // 
            this.chkEmpD.AutoSize = true;
            this.chkEmpD.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpD.Location = new System.Drawing.Point(149, 487);
            this.chkEmpD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpD.Name = "chkEmpD";
            this.chkEmpD.Size = new System.Drawing.Size(205, 31);
            this.chkEmpD.TabIndex = 59;
            this.chkEmpD.Text = "Empleado Diurno";
            this.chkEmpD.UseVisualStyleBackColor = true;
            this.chkEmpD.CheckStateChanged += new System.EventHandler(this.ChkEmpD_CheckStateChanged);
            // 
            // chkEmpN
            // 
            this.chkEmpN.AutoSize = true;
            this.chkEmpN.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpN.Location = new System.Drawing.Point(149, 528);
            this.chkEmpN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEmpN.Name = "chkEmpN";
            this.chkEmpN.Size = new System.Drawing.Size(231, 31);
            this.chkEmpN.TabIndex = 60;
            this.chkEmpN.Text = "Empleado Nocturno";
            this.chkEmpN.UseVisualStyleBackColor = true;
            this.chkEmpN.CheckedChanged += new System.EventHandler(this.ChkEmpN_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdE:";
            // 
            // gridEmpleadosD
            // 
            this.gridEmpleadosD.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gridEmpleadosD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmpleadosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosD.Location = new System.Drawing.Point(612, 63);
            this.gridEmpleadosD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosD.Name = "gridEmpleadosD";
            this.gridEmpleadosD.RowHeadersWidth = 62;
            this.gridEmpleadosD.Size = new System.Drawing.Size(982, 138);
            this.gridEmpleadosD.TabIndex = 81;
            this.gridEmpleadosD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosD_RowHeaderMouseClick);
            // 
            // btnEliminarEmpN
            // 
            this.btnEliminarEmpN.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpN.Location = new System.Drawing.Point(321, 755);
            this.btnEliminarEmpN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpN.Name = "btnEliminarEmpN";
            this.btnEliminarEmpN.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpN.TabIndex = 86;
            this.btnEliminarEmpN.Text = "Eliminar Empleado Nocturno";
            this.btnEliminarEmpN.UseVisualStyleBackColor = true;
            this.btnEliminarEmpN.Click += new System.EventHandler(this.btnEliminarEmpN_Click_1);
            // 
            // btnEliminarEmpD
            // 
            this.btnEliminarEmpD.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpD.Location = new System.Drawing.Point(321, 710);
            this.btnEliminarEmpD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpD.Name = "btnEliminarEmpD";
            this.btnEliminarEmpD.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpD.TabIndex = 85;
            this.btnEliminarEmpD.Text = "Eliminar Empleado Diurno";
            this.btnEliminarEmpD.UseVisualStyleBackColor = true;
            this.btnEliminarEmpD.Click += new System.EventHandler(this.btnEliminarEmpD_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(18, 889);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(294, 35);
            this.btnBorrar.TabIndex = 84;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmp.Location = new System.Drawing.Point(19, 710);
            this.btnAgregarEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(294, 35);
            this.btnAgregarEmp.TabIndex = 83;
            this.btnAgregarEmp.Text = "Agregar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(204, 14);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 34);
            this.label20.TabIndex = 82;
            this.label20.Text = "Empleados";
            // 
            // gridEmpleadosN
            // 
            this.gridEmpleadosN.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gridEmpleadosN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmpleadosN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosN.Location = new System.Drawing.Point(610, 270);
            this.gridEmpleadosN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosN.Name = "gridEmpleadosN";
            this.gridEmpleadosN.RowHeadersWidth = 62;
            this.gridEmpleadosN.Size = new System.Drawing.Size(982, 140);
            this.gridEmpleadosN.TabIndex = 79;
            this.gridEmpleadosN.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosN_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(615, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 34);
            this.label9.TabIndex = 78;
            this.label9.Text = "Lista Empleados Nocturnos";
            // 
            // txtTurno
            // 
            this.txtTurno.Enabled = false;
            this.txtTurno.Location = new System.Drawing.Point(610, 271);
            this.txtTurno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(148, 26);
            this.txtTurno.TabIndex = 87;
            this.txtTurno.Visible = false;
            this.txtTurno.TextChanged += new System.EventHandler(this.txtTurno_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(615, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 34);
            this.label8.TabIndex = 77;
            this.label8.Text = "Lista Empleados Diurnos";
            // 
            // lbVespertino
            // 
            this.lbVespertino.AutoSize = true;
            this.lbVespertino.BackColor = System.Drawing.Color.Transparent;
            this.lbVespertino.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVespertino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVespertino.Location = new System.Drawing.Point(618, 422);
            this.lbVespertino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVespertino.Name = "lbVespertino";
            this.lbVespertino.Size = new System.Drawing.Size(392, 34);
            this.lbVespertino.TabIndex = 95;
            this.lbVespertino.Text = "Lista Empleados Vespertinos";
            this.lbVespertino.Click += new System.EventHandler(this.lbVespertino_Click);
            // 
            // gridEmpleadosV
            // 
            this.gridEmpleadosV.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gridEmpleadosV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmpleadosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosV.Location = new System.Drawing.Point(612, 473);
            this.gridEmpleadosV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridEmpleadosV.Name = "gridEmpleadosV";
            this.gridEmpleadosV.RowHeadersWidth = 62;
            this.gridEmpleadosV.Size = new System.Drawing.Size(982, 148);
            this.gridEmpleadosV.TabIndex = 96;
            this.gridEmpleadosV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosV_RowHeaderMouseClick);
            // 
            // btnEliminarEmpV
            // 
            this.btnEliminarEmpV.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpV.Location = new System.Drawing.Point(321, 800);
            this.btnEliminarEmpV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEmpV.Name = "btnEliminarEmpV";
            this.btnEliminarEmpV.Size = new System.Drawing.Size(266, 35);
            this.btnEliminarEmpV.TabIndex = 97;
            this.btnEliminarEmpV.Text = "Eliminar Empleado Vespertino";
            this.btnEliminarEmpV.UseVisualStyleBackColor = true;
            this.btnEliminarEmpV.Click += new System.EventHandler(this.btnEliminarEmpV_Click);
            // 
            // btnSalarioMV
            // 
            this.btnSalarioMV.Font = new System.Drawing.Font("Lato", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMV.Location = new System.Drawing.Point(321, 934);
            this.btnSalarioMV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalarioMV.Name = "btnSalarioMV";
            this.btnSalarioMV.Size = new System.Drawing.Size(266, 35);
            this.btnSalarioMV.TabIndex = 98;
            this.btnSalarioMV.Text = "Salario Mayor V";
            this.btnSalarioMV.UseVisualStyleBackColor = true;
            this.btnSalarioMV.Click += new System.EventHandler(this.btnSalarioMV_Click);
            // 
            // gridEmpleadosT
            // 
            this.gridEmpleadosT.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gridEmpleadosT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmpleadosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosT.Location = new System.Drawing.Point(610, 681);
            this.gridEmpleadosT.Name = "gridEmpleadosT";
            this.gridEmpleadosT.RowHeadersWidth = 62;
            this.gridEmpleadosT.RowTemplate.Height = 28;
            this.gridEmpleadosT.Size = new System.Drawing.Size(982, 139);
            this.gridEmpleadosT.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(618, 632);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 34);
            this.label6.TabIndex = 100;
            this.label6.Text = "Lista Empleados Temporal";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1636, 1050);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridEmpleadosT);
            this.Controls.Add(this.btnSalarioMV);
            this.Controls.Add(this.btnEliminarEmpV);
            this.Controls.Add(this.gridEmpleadosV);
            this.Controls.Add(this.lbVespertino);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnSalarioMN);
            this.Controls.Add(this.btnSalarioMD);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.btnTotalE);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridEmpleadosD);
            this.Controls.Add(this.btnEliminarEmpN);
            this.Controls.Add(this.btnEliminarEmpD);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.gridEmpleadosN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnSalarioMN;
        private System.Windows.Forms.Button btnSalarioMD;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.Button btnTotalE;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEmpD;
        private System.Windows.Forms.CheckBox chkEmpN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridEmpleadosD;
        private System.Windows.Forms.Button btnEliminarEmpN;
        private System.Windows.Forms.Button btnEliminarEmpD;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView gridEmpleadosN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.CheckBox chkEmpV;
        private Label lbVespertino;
        private DataGridView gridEmpleadosV;
        private Button btnEliminarEmpV;
        private Button btnSalarioMV;
        private CheckBox chkTemporal;
        private Label label5;
        private TextBox txtSeguro;
        private Label lbSeguro;
        private DataGridView gridEmpleadosT;
        private Label label6;
    }
}

