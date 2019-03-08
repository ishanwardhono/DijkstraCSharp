/*
 * Created by SharpDevelop.
 * User: Dono
 * Date: 12/24/2016
 * Time: 2:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shortest_Path
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Medan = new System.Windows.Forms.PictureBox();
			this.medanSelayang = new System.Windows.Forms.Button();
			this.lbl_medanSelayang = new System.Windows.Forms.Label();
			this.lbl_medanJohor = new System.Windows.Forms.Label();
			this.medanJohor = new System.Windows.Forms.Button();
			this.lbl_medanAmplas = new System.Windows.Forms.Label();
			this.medanAmplas = new System.Windows.Forms.Button();
			this.medanSunggal = new System.Windows.Forms.Button();
			this.lbl_medanSunggal = new System.Windows.Forms.Label();
			this.lbl_medanG_BPMAK = new System.Windows.Forms.Label();
			this.medanG_BPMAK = new System.Windows.Forms.Button();
			this.medanDenai = new System.Windows.Forms.Button();
			this.lbl_medanDenai = new System.Windows.Forms.Label();
			this.medanHeletia = new System.Windows.Forms.Button();
			this.lbl_medanHelvetia = new System.Windows.Forms.Label();
			this.lbl_medanTuntungan = new System.Windows.Forms.Label();
			this.medanTuntungan = new System.Windows.Forms.Button();
			this.medanG_PBTP = new System.Windows.Forms.Button();
			this.lbl_medanG_PBTP = new System.Windows.Forms.Label();
			this.lbl_medanTembung = new System.Windows.Forms.Label();
			this.medanTembung = new System.Windows.Forms.Button();
			this.lbl_medanDeli = new System.Windows.Forms.Label();
			this.medanDeli = new System.Windows.Forms.Button();
			this.lbl_medanMarelan = new System.Windows.Forms.Label();
			this.medanMarelan = new System.Windows.Forms.Button();
			this.lbl_medanLabuhan = new System.Windows.Forms.Label();
			this.medanLabuhan = new System.Windows.Forms.Button();
			this.lbl_medanBelawan = new System.Windows.Forms.Label();
			this.medanBelawan = new System.Windows.Forms.Button();
			this.lbl_source = new System.Windows.Forms.Label();
			this.lbl_target = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_jarak = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lv_path = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.Medan)).BeginInit();
			this.SuspendLayout();
			// 
			// Medan
			// 
			this.Medan.Image = ((System.Drawing.Image)(resources.GetObject("Medan.Image")));
			this.Medan.Location = new System.Drawing.Point(13, 13);
			this.Medan.Name = "Medan";
			this.Medan.Size = new System.Drawing.Size(461, 690);
			this.Medan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Medan.TabIndex = 0;
			this.Medan.TabStop = false;
			// 
			// medanSelayang
			// 
			this.medanSelayang.BackColor = System.Drawing.Color.Maroon;
			this.medanSelayang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanSelayang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanSelayang.Location = new System.Drawing.Point(167, 546);
			this.medanSelayang.Name = "medanSelayang";
			this.medanSelayang.Size = new System.Drawing.Size(15, 15);
			this.medanSelayang.TabIndex = 1;
			this.medanSelayang.UseVisualStyleBackColor = false;
			this.medanSelayang.Click += new System.EventHandler(this.MedanSelayangClick);
			this.medanSelayang.MouseLeave += new System.EventHandler(this.MedanSelayangMouseLeave);
			this.medanSelayang.MouseHover += new System.EventHandler(this.MedanSelayangMouseHover);
			// 
			// lbl_medanSelayang
			// 
			this.lbl_medanSelayang.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanSelayang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanSelayang.Location = new System.Drawing.Point(118, 520);
			this.lbl_medanSelayang.Name = "lbl_medanSelayang";
			this.lbl_medanSelayang.Size = new System.Drawing.Size(110, 23);
			this.lbl_medanSelayang.TabIndex = 2;
			this.lbl_medanSelayang.Text = "Medan Selayang";
			this.lbl_medanSelayang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanSelayang.Visible = false;
			// 
			// lbl_medanJohor
			// 
			this.lbl_medanJohor.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanJohor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanJohor.Location = new System.Drawing.Point(204, 561);
			this.lbl_medanJohor.Name = "lbl_medanJohor";
			this.lbl_medanJohor.Size = new System.Drawing.Size(81, 23);
			this.lbl_medanJohor.TabIndex = 3;
			this.lbl_medanJohor.Text = "Medan Johor";
			this.lbl_medanJohor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanJohor.Visible = false;
			// 
			// medanJohor
			// 
			this.medanJohor.BackColor = System.Drawing.Color.Maroon;
			this.medanJohor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanJohor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanJohor.Location = new System.Drawing.Point(235, 587);
			this.medanJohor.Name = "medanJohor";
			this.medanJohor.Size = new System.Drawing.Size(15, 15);
			this.medanJohor.TabIndex = 4;
			this.medanJohor.UseVisualStyleBackColor = false;
			this.medanJohor.Click += new System.EventHandler(this.MedanJohorClick);
			this.medanJohor.MouseLeave += new System.EventHandler(this.MedanJohorMouseLeave);
			this.medanJohor.MouseHover += new System.EventHandler(this.medanJohorMouseHover);
			// 
			// lbl_medanAmplas
			// 
			this.lbl_medanAmplas.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanAmplas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanAmplas.Location = new System.Drawing.Point(280, 538);
			this.lbl_medanAmplas.Name = "lbl_medanAmplas";
			this.lbl_medanAmplas.Size = new System.Drawing.Size(91, 23);
			this.lbl_medanAmplas.TabIndex = 5;
			this.lbl_medanAmplas.Text = "Medan Amplas";
			this.lbl_medanAmplas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanAmplas.Visible = false;
			// 
			// medanAmplas
			// 
			this.medanAmplas.BackColor = System.Drawing.Color.Maroon;
			this.medanAmplas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanAmplas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanAmplas.Location = new System.Drawing.Point(321, 564);
			this.medanAmplas.Name = "medanAmplas";
			this.medanAmplas.Size = new System.Drawing.Size(15, 15);
			this.medanAmplas.TabIndex = 6;
			this.medanAmplas.UseVisualStyleBackColor = false;
			this.medanAmplas.Click += new System.EventHandler(this.MedanAmplasClick);
			this.medanAmplas.MouseLeave += new System.EventHandler(this.MedanAmplasMouseLeave);
			this.medanAmplas.MouseHover += new System.EventHandler(this.MedanAmplasMouseHover);
			// 
			// medanSunggal
			// 
			this.medanSunggal.BackColor = System.Drawing.Color.Maroon;
			this.medanSunggal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanSunggal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanSunggal.Location = new System.Drawing.Point(164, 486);
			this.medanSunggal.Name = "medanSunggal";
			this.medanSunggal.Size = new System.Drawing.Size(15, 15);
			this.medanSunggal.TabIndex = 8;
			this.medanSunggal.UseVisualStyleBackColor = false;
			this.medanSunggal.Click += new System.EventHandler(this.MedanSunggalClick);
			this.medanSunggal.MouseLeave += new System.EventHandler(this.MedanSunggalMouseLeave);
			this.medanSunggal.MouseHover += new System.EventHandler(this.MedanSunggalMouseHover);
			// 
			// lbl_medanSunggal
			// 
			this.lbl_medanSunggal.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanSunggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanSunggal.Location = new System.Drawing.Point(118, 460);
			this.lbl_medanSunggal.Name = "lbl_medanSunggal";
			this.lbl_medanSunggal.Size = new System.Drawing.Size(95, 23);
			this.lbl_medanSunggal.TabIndex = 7;
			this.lbl_medanSunggal.Text = "Medan Sunggal";
			this.lbl_medanSunggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanSunggal.Visible = false;
			// 
			// lbl_medanG_BPMAK
			// 
			this.lbl_medanG_BPMAK.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanG_BPMAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanG_BPMAK.Location = new System.Drawing.Point(134, 493);
			this.lbl_medanG_BPMAK.Name = "lbl_medanG_BPMAK";
			this.lbl_medanG_BPMAK.Size = new System.Drawing.Size(247, 23);
			this.lbl_medanG_BPMAK.TabIndex = 10;
			this.lbl_medanG_BPMAK.Text = "Medan Baru, Polonia, Maimun, Area, Kota";
			this.lbl_medanG_BPMAK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanG_BPMAK.Visible = false;
			// 
			// medanG_BPMAK
			// 
			this.medanG_BPMAK.BackColor = System.Drawing.Color.Maroon;
			this.medanG_BPMAK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanG_BPMAK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanG_BPMAK.Location = new System.Drawing.Point(253, 519);
			this.medanG_BPMAK.Name = "medanG_BPMAK";
			this.medanG_BPMAK.Size = new System.Drawing.Size(15, 15);
			this.medanG_BPMAK.TabIndex = 9;
			this.medanG_BPMAK.UseVisualStyleBackColor = false;
			this.medanG_BPMAK.Click += new System.EventHandler(this.MedanG_BPMAKClick);
			this.medanG_BPMAK.MouseLeave += new System.EventHandler(this.MedanG_BPMAKMouseLeave);
			this.medanG_BPMAK.MouseHover += new System.EventHandler(this.MedanG_BPMAKMouseHover);
			// 
			// medanDenai
			// 
			this.medanDenai.BackColor = System.Drawing.Color.Maroon;
			this.medanDenai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanDenai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanDenai.Location = new System.Drawing.Point(347, 486);
			this.medanDenai.Name = "medanDenai";
			this.medanDenai.Size = new System.Drawing.Size(15, 15);
			this.medanDenai.TabIndex = 12;
			this.medanDenai.UseVisualStyleBackColor = false;
			this.medanDenai.Click += new System.EventHandler(this.MedanDenaiClick);
			this.medanDenai.MouseLeave += new System.EventHandler(this.MedanDenaiMouseLeave);
			this.medanDenai.MouseHover += new System.EventHandler(this.MedanDenaiMouseHover);
			// 
			// lbl_medanDenai
			// 
			this.lbl_medanDenai.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanDenai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanDenai.Location = new System.Drawing.Point(321, 460);
			this.lbl_medanDenai.Name = "lbl_medanDenai";
			this.lbl_medanDenai.Size = new System.Drawing.Size(84, 23);
			this.lbl_medanDenai.TabIndex = 11;
			this.lbl_medanDenai.Text = "Medan Denai";
			this.lbl_medanDenai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanDenai.Visible = false;
			// 
			// medanHeletia
			// 
			this.medanHeletia.BackColor = System.Drawing.Color.Maroon;
			this.medanHeletia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanHeletia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanHeletia.Location = new System.Drawing.Point(154, 430);
			this.medanHeletia.Name = "medanHeletia";
			this.medanHeletia.Size = new System.Drawing.Size(15, 15);
			this.medanHeletia.TabIndex = 14;
			this.medanHeletia.UseVisualStyleBackColor = false;
			this.medanHeletia.Click += new System.EventHandler(this.MedanHeletiaClick);
			this.medanHeletia.MouseLeave += new System.EventHandler(this.MedanHeletiaMouseLeave);
			this.medanHeletia.MouseHover += new System.EventHandler(this.MedanHeletiaMouseHover);
			// 
			// lbl_medanHelvetia
			// 
			this.lbl_medanHelvetia.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanHelvetia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanHelvetia.Location = new System.Drawing.Point(108, 404);
			this.lbl_medanHelvetia.Name = "lbl_medanHelvetia";
			this.lbl_medanHelvetia.Size = new System.Drawing.Size(105, 23);
			this.lbl_medanHelvetia.TabIndex = 13;
			this.lbl_medanHelvetia.Text = "Medan Helvetia";
			this.lbl_medanHelvetia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanHelvetia.Visible = false;
			// 
			// lbl_medanTuntungan
			// 
			this.lbl_medanTuntungan.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanTuntungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanTuntungan.Location = new System.Drawing.Point(72, 583);
			this.lbl_medanTuntungan.Name = "lbl_medanTuntungan";
			this.lbl_medanTuntungan.Size = new System.Drawing.Size(110, 23);
			this.lbl_medanTuntungan.TabIndex = 16;
			this.lbl_medanTuntungan.Text = "Medan Tuntungan";
			this.lbl_medanTuntungan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanTuntungan.Visible = false;
			// 
			// medanTuntungan
			// 
			this.medanTuntungan.BackColor = System.Drawing.Color.Maroon;
			this.medanTuntungan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanTuntungan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanTuntungan.Location = new System.Drawing.Point(121, 609);
			this.medanTuntungan.Name = "medanTuntungan";
			this.medanTuntungan.Size = new System.Drawing.Size(15, 15);
			this.medanTuntungan.TabIndex = 15;
			this.medanTuntungan.UseVisualStyleBackColor = false;
			this.medanTuntungan.Click += new System.EventHandler(this.MedanTuntunganClick);
			this.medanTuntungan.MouseLeave += new System.EventHandler(this.MedanTuntunganMouseLeave);
			this.medanTuntungan.MouseHover += new System.EventHandler(this.MedanTuntunganMouseHover);
			// 
			// medanG_PBTP
			// 
			this.medanG_PBTP.BackColor = System.Drawing.Color.Maroon;
			this.medanG_PBTP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanG_PBTP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanG_PBTP.Location = new System.Drawing.Point(253, 398);
			this.medanG_PBTP.Name = "medanG_PBTP";
			this.medanG_PBTP.Size = new System.Drawing.Size(15, 15);
			this.medanG_PBTP.TabIndex = 18;
			this.medanG_PBTP.UseVisualStyleBackColor = false;
			this.medanG_PBTP.Click += new System.EventHandler(this.MedanG_PBTPClick);
			this.medanG_PBTP.MouseLeave += new System.EventHandler(this.MedanG_PBTPMouseLeave);
			this.medanG_PBTP.MouseHover += new System.EventHandler(this.MedanG_PBTPMouseHover);
			// 
			// lbl_medanG_PBTP
			// 
			this.lbl_medanG_PBTP.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanG_PBTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanG_PBTP.Location = new System.Drawing.Point(141, 372);
			this.lbl_medanG_PBTP.Name = "lbl_medanG_PBTP";
			this.lbl_medanG_PBTP.Size = new System.Drawing.Size(240, 23);
			this.lbl_medanG_PBTP.TabIndex = 17;
			this.lbl_medanG_PBTP.Text = "Medan Petisah, Barat, Timur, Perjuangan";
			this.lbl_medanG_PBTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanG_PBTP.Visible = false;
			// 
			// lbl_medanTembung
			// 
			this.lbl_medanTembung.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanTembung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanTembung.Location = new System.Drawing.Point(285, 415);
			this.lbl_medanTembung.Name = "lbl_medanTembung";
			this.lbl_medanTembung.Size = new System.Drawing.Size(108, 23);
			this.lbl_medanTembung.TabIndex = 20;
			this.lbl_medanTembung.Text = "Medan Tembung";
			this.lbl_medanTembung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanTembung.Visible = false;
			// 
			// medanTembung
			// 
			this.medanTembung.BackColor = System.Drawing.Color.Maroon;
			this.medanTembung.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanTembung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanTembung.Location = new System.Drawing.Point(334, 441);
			this.medanTembung.Name = "medanTembung";
			this.medanTembung.Size = new System.Drawing.Size(15, 15);
			this.medanTembung.TabIndex = 19;
			this.medanTembung.UseVisualStyleBackColor = false;
			this.medanTembung.Click += new System.EventHandler(this.MedanTembungClick);
			this.medanTembung.MouseLeave += new System.EventHandler(this.MedanTembungMouseLeave);
			this.medanTembung.MouseHover += new System.EventHandler(this.MedanTembungMouseHover);
			// 
			// lbl_medanDeli
			// 
			this.lbl_medanDeli.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanDeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanDeli.Location = new System.Drawing.Point(215, 301);
			this.lbl_medanDeli.Name = "lbl_medanDeli";
			this.lbl_medanDeli.Size = new System.Drawing.Size(84, 23);
			this.lbl_medanDeli.TabIndex = 22;
			this.lbl_medanDeli.Text = "Medan Deli";
			this.lbl_medanDeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanDeli.Visible = false;
			// 
			// medanDeli
			// 
			this.medanDeli.BackColor = System.Drawing.Color.Maroon;
			this.medanDeli.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanDeli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanDeli.Location = new System.Drawing.Point(250, 327);
			this.medanDeli.Name = "medanDeli";
			this.medanDeli.Size = new System.Drawing.Size(15, 15);
			this.medanDeli.TabIndex = 21;
			this.medanDeli.UseVisualStyleBackColor = false;
			this.medanDeli.Click += new System.EventHandler(this.MedanDeliClick);
			this.medanDeli.MouseLeave += new System.EventHandler(this.MedanDeliMouseLeave);
			this.medanDeli.MouseHover += new System.EventHandler(this.MedanDeliMouseHover);
			// 
			// lbl_medanMarelan
			// 
			this.lbl_medanMarelan.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanMarelan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanMarelan.Location = new System.Drawing.Point(154, 192);
			this.lbl_medanMarelan.Name = "lbl_medanMarelan";
			this.lbl_medanMarelan.Size = new System.Drawing.Size(102, 23);
			this.lbl_medanMarelan.TabIndex = 24;
			this.lbl_medanMarelan.Text = "Medan Marelan";
			this.lbl_medanMarelan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanMarelan.Visible = false;
			// 
			// medanMarelan
			// 
			this.medanMarelan.BackColor = System.Drawing.Color.Maroon;
			this.medanMarelan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanMarelan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanMarelan.Location = new System.Drawing.Point(198, 218);
			this.medanMarelan.Name = "medanMarelan";
			this.medanMarelan.Size = new System.Drawing.Size(15, 15);
			this.medanMarelan.TabIndex = 23;
			this.medanMarelan.UseVisualStyleBackColor = false;
			this.medanMarelan.Click += new System.EventHandler(this.MedanMarelanClick);
			this.medanMarelan.MouseLeave += new System.EventHandler(this.MedanMarelanMouseLeave);
			this.medanMarelan.MouseHover += new System.EventHandler(this.MedanMarelanMouseHover);
			// 
			// lbl_medanLabuhan
			// 
			this.lbl_medanLabuhan.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanLabuhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanLabuhan.Location = new System.Drawing.Point(247, 169);
			this.lbl_medanLabuhan.Name = "lbl_medanLabuhan";
			this.lbl_medanLabuhan.Size = new System.Drawing.Size(102, 23);
			this.lbl_medanLabuhan.TabIndex = 26;
			this.lbl_medanLabuhan.Text = "Medan Labuhan";
			this.lbl_medanLabuhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanLabuhan.Visible = false;
			// 
			// medanLabuhan
			// 
			this.medanLabuhan.BackColor = System.Drawing.Color.Maroon;
			this.medanLabuhan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanLabuhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanLabuhan.Location = new System.Drawing.Point(291, 195);
			this.medanLabuhan.Name = "medanLabuhan";
			this.medanLabuhan.Size = new System.Drawing.Size(15, 15);
			this.medanLabuhan.TabIndex = 25;
			this.medanLabuhan.UseVisualStyleBackColor = false;
			this.medanLabuhan.Click += new System.EventHandler(this.MedanLabuhanClick);
			this.medanLabuhan.MouseLeave += new System.EventHandler(this.MedanLabuhanMouseLeave);
			this.medanLabuhan.MouseHover += new System.EventHandler(this.MedanLabuhanMouseHover);
			// 
			// lbl_medanBelawan
			// 
			this.lbl_medanBelawan.BackColor = System.Drawing.Color.YellowGreen;
			this.lbl_medanBelawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_medanBelawan.Location = new System.Drawing.Point(197, 77);
			this.lbl_medanBelawan.Name = "lbl_medanBelawan";
			this.lbl_medanBelawan.Size = new System.Drawing.Size(102, 23);
			this.lbl_medanBelawan.TabIndex = 28;
			this.lbl_medanBelawan.Text = "Medan Belawan";
			this.lbl_medanBelawan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_medanBelawan.Visible = false;
			// 
			// medanBelawan
			// 
			this.medanBelawan.BackColor = System.Drawing.Color.Maroon;
			this.medanBelawan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.medanBelawan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.medanBelawan.Location = new System.Drawing.Point(241, 103);
			this.medanBelawan.Name = "medanBelawan";
			this.medanBelawan.Size = new System.Drawing.Size(15, 15);
			this.medanBelawan.TabIndex = 27;
			this.medanBelawan.UseVisualStyleBackColor = false;
			this.medanBelawan.Click += new System.EventHandler(this.MedanBelawanClick);
			this.medanBelawan.MouseLeave += new System.EventHandler(this.MedanBelawanMouseLeave);
			this.medanBelawan.MouseHover += new System.EventHandler(this.MedanBelawanMouseHover);
			// 
			// lbl_source
			// 
			this.lbl_source.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_source.Location = new System.Drawing.Point(480, 95);
			this.lbl_source.Name = "lbl_source";
			this.lbl_source.Size = new System.Drawing.Size(381, 23);
			this.lbl_source.TabIndex = 30;
			this.lbl_source.Text = "-";
			// 
			// lbl_target
			// 
			this.lbl_target.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_target.Location = new System.Drawing.Point(479, 170);
			this.lbl_target.Name = "lbl_target";
			this.lbl_target.Size = new System.Drawing.Size(382, 23);
			this.lbl_target.TabIndex = 31;
			this.lbl_target.Text = "-";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(480, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 32;
			this.label1.Text = "Asal :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(480, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 33;
			this.label2.Text = "Tujuan :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(479, 218);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 34;
			this.label3.Text = "Jarak :";
			// 
			// lbl_jarak
			// 
			this.lbl_jarak.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_jarak.Location = new System.Drawing.Point(481, 245);
			this.lbl_jarak.Name = "lbl_jarak";
			this.lbl_jarak.Size = new System.Drawing.Size(268, 58);
			this.lbl_jarak.TabIndex = 35;
			this.lbl_jarak.Text = "-";
			this.lbl_jarak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(481, 328);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 36;
			this.label4.Text = "Jalur :";
			// 
			// lv_path
			// 
			this.lv_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lv_path.FormattingEnabled = true;
			this.lv_path.HorizontalScrollbar = true;
			this.lv_path.ItemHeight = 18;
			this.lv_path.Location = new System.Drawing.Point(481, 343);
			this.lv_path.Name = "lv_path";
			this.lv_path.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lv_path.Size = new System.Drawing.Size(315, 130);
			this.lv_path.TabIndex = 38;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(835, 706);
			this.Controls.Add(this.lv_path);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbl_jarak);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_target);
			this.Controls.Add(this.lbl_source);
			this.Controls.Add(this.lbl_medanBelawan);
			this.Controls.Add(this.medanBelawan);
			this.Controls.Add(this.lbl_medanLabuhan);
			this.Controls.Add(this.medanLabuhan);
			this.Controls.Add(this.lbl_medanMarelan);
			this.Controls.Add(this.medanMarelan);
			this.Controls.Add(this.lbl_medanDeli);
			this.Controls.Add(this.medanDeli);
			this.Controls.Add(this.lbl_medanTembung);
			this.Controls.Add(this.medanTembung);
			this.Controls.Add(this.lbl_medanG_PBTP);
			this.Controls.Add(this.medanG_PBTP);
			this.Controls.Add(this.lbl_medanTuntungan);
			this.Controls.Add(this.medanTuntungan);
			this.Controls.Add(this.medanHeletia);
			this.Controls.Add(this.lbl_medanHelvetia);
			this.Controls.Add(this.lbl_medanG_BPMAK);
			this.Controls.Add(this.medanDenai);
			this.Controls.Add(this.lbl_medanDenai);
			this.Controls.Add(this.medanG_BPMAK);
			this.Controls.Add(this.medanSunggal);
			this.Controls.Add(this.lbl_medanSunggal);
			this.Controls.Add(this.medanAmplas);
			this.Controls.Add(this.lbl_medanAmplas);
			this.Controls.Add(this.medanJohor);
			this.Controls.Add(this.lbl_medanJohor);
			this.Controls.Add(this.lbl_medanSelayang);
			this.Controls.Add(this.medanSelayang);
			this.Controls.Add(this.Medan);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Shortest-Path";
			((System.ComponentModel.ISupportInitialize)(this.Medan)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox lv_path;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_jarak;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_target;
		private System.Windows.Forms.Label lbl_source;
		private System.Windows.Forms.Button medanBelawan;
		private System.Windows.Forms.Label lbl_medanBelawan;
		private System.Windows.Forms.Button medanLabuhan;
		private System.Windows.Forms.Label lbl_medanLabuhan;
		private System.Windows.Forms.Button medanMarelan;
		private System.Windows.Forms.Label lbl_medanMarelan;
		private System.Windows.Forms.Button medanDeli;
		private System.Windows.Forms.Label lbl_medanDeli;
		private System.Windows.Forms.Button medanTembung;
		private System.Windows.Forms.Label lbl_medanTembung;
		private System.Windows.Forms.Label lbl_medanG_PBTP;
		private System.Windows.Forms.Button medanG_PBTP;
		private System.Windows.Forms.Button medanTuntungan;
		private System.Windows.Forms.Label lbl_medanTuntungan;
		private System.Windows.Forms.Label lbl_medanHelvetia;
		private System.Windows.Forms.Button medanHeletia;
		private System.Windows.Forms.Label lbl_medanDenai;
		private System.Windows.Forms.Button medanDenai;
		private System.Windows.Forms.Button medanG_BPMAK;
		private System.Windows.Forms.Label lbl_medanG_BPMAK;
		private System.Windows.Forms.Label lbl_medanSunggal;
		private System.Windows.Forms.Button medanSunggal;
		private System.Windows.Forms.Button medanAmplas;
		private System.Windows.Forms.Label lbl_medanAmplas;
		private System.Windows.Forms.Button medanJohor;
		private System.Windows.Forms.Label lbl_medanJohor;
		private System.Windows.Forms.Label lbl_medanSelayang;
		private System.Windows.Forms.Button medanSelayang;
		private System.Windows.Forms.PictureBox Medan;
	}
}
