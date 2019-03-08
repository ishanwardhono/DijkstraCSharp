/*
 * Created by SharpDevelop.
 * User: Dono
 * Date: 12/24/2016
 * Time: 2:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shortest_Path
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Boolean mdnBelawan=false, mdnMarelan=false, mdnLabuhan=false, mdnDeli=false, mdnG_PBTP=false, mdnTembung=false, mdnHelvetia=false,
			mdnSunggal=false, mdnSelayang=false, mdnG_BPMAK=false, mdnDenai=false, mdnTuntungan=false, mdnJohor=false, mdnAmplas=false;
		
		String [] node = new String[]{"Medan Belawan","Medan Marelan","Medan Labuhan","Medan Deli","Medan Petisah, Barat, Timur, Perjuangan",
			"Medan Tembung","Medan Helvetia","Medan Sunggal","Medan Selayang","Medan Baru, Polonia, Maimun, Area, Kota","Medan Denai",
			"Medan Tuntungan","Medan Johor","Medan Amplas"};
				
		public static int INF = 9999;
		public static int N = 14;
		int tempTombol = 0, co, source, target;
		int m,MIN,start,d,j;
		int[] path = new int[N], prev = new int[N];
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void enabledVerteks()
		{
			medanBelawan.Enabled = true;
			medanBelawan.BackColor = System.Drawing.Color.Maroon;
			medanMarelan.Enabled = true;
			medanMarelan.BackColor = System.Drawing.Color.Maroon;
			medanLabuhan.Enabled = true;
			medanLabuhan.BackColor = System.Drawing.Color.Maroon;
			medanDeli.Enabled = true;
			medanDeli.BackColor = System.Drawing.Color.Maroon;
			medanG_PBTP.Enabled = true;
			medanG_PBTP.BackColor = System.Drawing.Color.Maroon;
			medanHeletia.Enabled = true;
			medanHeletia.BackColor = System.Drawing.Color.Maroon;
			medanSunggal.Enabled = true;
			medanSunggal.BackColor = System.Drawing.Color.Maroon;
			medanTembung.Enabled = true;
			medanTembung.BackColor = System.Drawing.Color.Maroon;
			medanSelayang.Enabled = true;
			medanSelayang.BackColor = System.Drawing.Color.Maroon;
			medanG_BPMAK.Enabled = true;
			medanG_BPMAK.BackColor = System.Drawing.Color.Maroon;
			medanDenai.Enabled = true;
			medanDenai.BackColor = System.Drawing.Color.Maroon;
			medanTuntungan.Enabled = true;
			medanTuntungan.BackColor = System.Drawing.Color.Maroon;
			medanJohor.Enabled = true;
			medanJohor.BackColor = System.Drawing.Color.Maroon;
			medanAmplas.Enabled = true;
			medanAmplas.BackColor = System.Drawing.Color.Maroon;
		}
		
		void tombolSourceTarget(int index)
		{
			enabledVerteks();
			if(tempTombol == 0){
				lbl_source.Text = node[index];
				source = index;
				tempTombol++;
			} else if(tempTombol == 1){
				lbl_target.Text = node[index];
				target = index;
				tempTombol++;
				/// <summary>
				/// path jalan kecamatan
				/// tombol lain enabled false
				/// </summary>
				/// 
				
				lv_path.Items.Clear();
				co = dijsktra(source,target);
				lbl_jarak.Text = co.ToString()+" Km";
				
				if(source != 0 && target != 0){
					medanBelawan.BackColor = System.Drawing.Color.IndianRed;
					medanBelawan.Enabled = false;
				}
				if(source != 1 && target != 1){
					medanMarelan.BackColor = System.Drawing.Color.IndianRed;
					medanMarelan.Enabled = false;
				}
				if(source != 2 && target != 2){
					medanLabuhan.BackColor = System.Drawing.Color.IndianRed;
					medanLabuhan.Enabled = false;
				}
				if(source != 3 && target != 3){
					medanDeli.BackColor = System.Drawing.Color.IndianRed;
					medanDeli.Enabled = false;
				}
				if(source != 4 && target != 4){
					medanG_PBTP.BackColor = System.Drawing.Color.IndianRed;
					medanG_PBTP.Enabled = false;
				}
				if(source != 5 && target != 5){
					medanTembung.BackColor = System.Drawing.Color.IndianRed;
					medanTembung.Enabled = false;
				}
				if(source != 6 && target != 6){
					medanHeletia.BackColor = System.Drawing.Color.IndianRed;
					medanHeletia.Enabled = false;
				}
				if(source != 7 && target != 7){
					medanSunggal.BackColor = System.Drawing.Color.IndianRed;
					medanSunggal.Enabled = false;
				}
				if(source != 8 && target != 8){
					medanSelayang.BackColor = System.Drawing.Color.IndianRed;
					medanSelayang.Enabled = false;
				}
				if(source != 9 && target != 9){
					medanG_BPMAK.BackColor = System.Drawing.Color.IndianRed;
					medanG_BPMAK.Enabled = false;
				}
				if(source != 10 && target != 10){
					medanDenai.BackColor = System.Drawing.Color.IndianRed;
					medanDenai.Enabled = false;
				}
				if(source != 11 && target != 11){
					medanTuntungan.BackColor = System.Drawing.Color.IndianRed;
					medanTuntungan.Enabled = false;
				}
				if(source != 12 && target != 12){
					medanJohor.BackColor = System.Drawing.Color.IndianRed;
					medanJohor.Enabled = false;
				}
				if(source != 13 && target != 13){
					medanAmplas.BackColor = System.Drawing.Color.IndianRed;
					medanAmplas.Enabled = false;
				}
				printPath();
			} else if(tempTombol == 2){
				tombolBatal(target);
			}
		}
		
		void tombolBatal(int index){
			enabledVerteks();
			tempTombol--;
			if(tempTombol == 0){
				lbl_source.Text = "-";
				lbl_jarak.Text = "-";
				lv_path.Items.Clear();
			} else if(tempTombol == 1){
				if(index == source){
					tempTombol = 0;
					tombolSourceTarget(target);
				}
				lbl_target.Text = "-";
				lv_path.Items.Clear();
				lbl_jarak.Text = "-";
			}
		}
		
		void MedanSelayangMouseHover(object sender, EventArgs e)
		{
			lbl_medanSelayang.Visible = true;
		}
		
		void medanJohorMouseHover(object sender, EventArgs e)
		{
			lbl_medanJohor.Visible = true;
		}
		
		void MedanJohorMouseLeave(object sender, EventArgs e)
		{
			if(mdnJohor == false)
				lbl_medanJohor.Visible = false;
		}
		
		void MedanSelayangMouseLeave(object sender, System.EventArgs e)
		{
			if(mdnSelayang == false)
				lbl_medanSelayang.Visible = false;
		}
		
		void MedanAmplasMouseHover(object sender, EventArgs e)
		{
			lbl_medanAmplas.Visible = true;
		}
		
		void MedanAmplasMouseLeave(object sender, EventArgs e)
		{
			if(mdnAmplas == false)
				lbl_medanAmplas.Visible = false;
		}
		
		void MedanSunggalMouseHover(object sender, EventArgs e)
		{
			lbl_medanSunggal.Visible = true;
		}
		
		void MedanSunggalMouseLeave(object sender, EventArgs e)
		{
			if(mdnSunggal == false)
				lbl_medanSunggal.Visible = false;
		}
		
		void MedanG_BPMAKMouseHover(object sender, EventArgs e)
		{
			lbl_medanG_BPMAK.Visible = true;
		}
		
		void MedanG_BPMAKMouseLeave(object sender, EventArgs e)
		{
			if(mdnG_BPMAK == false)
				lbl_medanG_BPMAK.Visible = false;
		}
		
		void MedanDenaiMouseHover(object sender, EventArgs e)
		{
			lbl_medanDenai.Visible = true;
		}
		
		void MedanDenaiMouseLeave(object sender, EventArgs e)
		{
			if(mdnDenai == false)
				lbl_medanDenai.Visible = false;
		}
		
		void MedanHeletiaMouseHover(object sender, EventArgs e)
		{
			lbl_medanHelvetia.Visible = true;
		}
		
		void MedanHeletiaMouseLeave(object sender, EventArgs e)
		{
			if(mdnHelvetia == false)
				lbl_medanHelvetia.Visible = false;
		}
		
		void MedanTuntunganMouseHover(object sender, EventArgs e)
		{
			lbl_medanTuntungan.Visible = true;
		}
		
		void MedanTuntunganMouseLeave(object sender, EventArgs e)
		{
			if(mdnTuntungan == false)
				lbl_medanTuntungan.Visible = false;
		}
		
		void MedanG_PBTPMouseHover(object sender, EventArgs e)
		{
			lbl_medanG_PBTP.Visible = true;
		}
		
		void MedanG_PBTPMouseLeave(object sender, EventArgs e)
		{
			if(mdnG_PBTP == false)
				lbl_medanG_PBTP.Visible = false;
		}
		
		void MedanTembungMouseHover(object sender, EventArgs e)
		{
			lbl_medanTembung.Visible = true;
		}
		
		void MedanTembungMouseLeave(object sender, EventArgs e)
		{
			if(mdnTembung == false)
				lbl_medanTembung.Visible = false;
		}
		
		void MedanDeliMouseHover(object sender, EventArgs e)
		{
			lbl_medanDeli.Visible = true;
		}
		
		void MedanDeliMouseLeave(object sender, EventArgs e)
		{
			if(mdnDeli == false)
				lbl_medanDeli.Visible = false;
		}
		
		void MedanMarelanMouseHover(object sender, EventArgs e)
		{
			lbl_medanMarelan.Visible = true;
		}
		
		void MedanMarelanMouseLeave(object sender, EventArgs e)
		{
			if(mdnMarelan == false)
				lbl_medanMarelan.Visible = false;
		}
		
		void MedanLabuhanMouseHover(object sender, EventArgs e)
		{
			lbl_medanLabuhan.Visible = true;
		}
		
		void MedanLabuhanMouseLeave(object sender, EventArgs e)
		{
			if(mdnLabuhan == false)
				lbl_medanLabuhan.Visible = false;
		}
		
		void MedanBelawanMouseHover(object sender, EventArgs e)
		{
			lbl_medanBelawan.Visible = true;
		}
		
		void MedanBelawanMouseLeave(object sender, EventArgs e)
		{
			if(mdnBelawan == false)
				lbl_medanBelawan.Visible = false;
		}
		
		
		//mouse click
		void MedanJohorClick(object sender, EventArgs e)
		{
			if(mdnJohor == true){
				mdnJohor = false;
				lbl_medanJohor.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(12);
			}else{
				mdnJohor = true;
				lbl_medanJohor.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(12);
			}
		}
		
		void MedanTuntunganClick(object sender, EventArgs e)
		{
			if(mdnTuntungan == true){
				mdnTuntungan = false;
				lbl_medanTuntungan.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(11);
			}else{
				mdnTuntungan = true;
				lbl_medanTuntungan.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(11);
			}
		}
		
		void MedanAmplasClick(object sender, EventArgs e)
		{
			if(mdnAmplas == true){
				mdnAmplas = false;
				lbl_medanAmplas.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(13);
			}else{
				mdnAmplas = true;
				lbl_medanAmplas.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(13);
			}
		}
		
		void MedanSelayangClick(object sender, EventArgs e)
		{
			if(mdnSelayang == true){
				mdnSelayang = false;
				lbl_medanSelayang.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(8);
			}else{
				mdnSelayang = true;
				lbl_medanSelayang.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(8);
			}
		}
		
		void MedanSunggalClick(object sender, EventArgs e)
		{
			if(mdnSunggal == true){
				mdnSunggal = false;
				lbl_medanSunggal.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(7);
			}else{
				mdnSunggal = true;
				lbl_medanSunggal.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(7);
			}
		}
		
		void MedanG_BPMAKClick(object sender, EventArgs e)
		{
			if(mdnG_BPMAK == true){
				mdnG_BPMAK = false;
				lbl_medanG_BPMAK.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(9);
			}else{
				mdnG_BPMAK = true;
				lbl_medanG_BPMAK.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(9);
			}
		}
		
		void MedanDenaiClick(object sender, EventArgs e)
		{
			if(mdnDenai == true){
				mdnDenai = false;
				lbl_medanDenai.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(10);
			}else{
				mdnDenai = true;
				lbl_medanDenai.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(10);
			}
		}
		
		void MedanTembungClick(object sender, EventArgs e)
		{
			if(mdnTembung == true){
				mdnTembung = false;
				lbl_medanTembung.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(5);
			}else{
				mdnTembung = true;
				lbl_medanTembung.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(5);
			}
		}
		
		void MedanG_PBTPClick(object sender, EventArgs e)
		{
			if(mdnG_PBTP == true){
				mdnG_PBTP =false;
				lbl_medanG_PBTP.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(4);
			}else{
				mdnG_PBTP = true;
				lbl_medanG_PBTP.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(4);
			}
		}
		
		void MedanHeletiaClick(object sender, EventArgs e)
		{
			if(mdnHelvetia == true){
				mdnHelvetia = false;
				lbl_medanHelvetia.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(6);
			}else{
				mdnHelvetia = true;
				lbl_medanHelvetia.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(6);
			}
		}
		
		void MedanDeliClick(object sender, EventArgs e)
		{
			if(mdnDeli == true){
				mdnDeli = false;
				lbl_medanDeli.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(3);
			}else{
				mdnDeli = true;
				lbl_medanDeli.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(3);
			}
		}
		
		void MedanMarelanClick(object sender, EventArgs e)
		{
			if(mdnMarelan == true){
				mdnMarelan = false;
				lbl_medanMarelan.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(1);
			}else{
				mdnMarelan = true;
				lbl_medanMarelan.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(1);
			}
		}
		
		void MedanLabuhanClick(object sender, EventArgs e)
		{
			if(mdnLabuhan == true){
				mdnLabuhan = false;
				lbl_medanLabuhan.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(2);
			}else{
				mdnLabuhan = true;
				lbl_medanLabuhan.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(2);
			}
		}
		
		void MedanBelawanClick(object sender, EventArgs e)
		{
			if(mdnBelawan == true){
				mdnBelawan = false;
				lbl_medanBelawan.BackColor = System.Drawing.Color.YellowGreen;
				tombolBatal(0);
			}else{
				mdnBelawan = true;
				lbl_medanBelawan.BackColor = System.Drawing.Color.Yellow;
				tombolSourceTarget(0);
			}
		}
		
		int dijsktra(int source,int target)
		{
			int[,] a = new int[N,N];
			int[,] cost = new int[N,N];
			int[] dist = new int[N], selected = new int[N];
		
			for(int i=0;i<N;i++){
		        for(int j=0;j<N;j++){
					a[i,j] = INF;
		        }
		    }
		
		    a[0,1]  = 12;
		    a[0,2]  = 11;
		    a[1,2]  =  6;
		    a[1,6]  = 15;
		    a[2,3]  = 13;
		    a[3,4]  =  7;
		    a[4,5]  =  9;
		    a[4,6]  =  4;
		    a[4,9]  =  5;
		    a[5,10] =  5;
		    a[6,7]  =  6;
		    a[6,9]  =  7;
		    a[7,8]  =  5;
		    a[7,9]  =  9;
		    a[8,9]  =  9;
		    a[8,11] =  6;
		    a[8,12] =  6;
		    a[9,10] =  4;
		    a[9,12] =  9;
		    a[9,13] =  7;
		    a[10,13] =  6;
		    a[11,12] =  9;
		    a[12,13] =  8;
		
		    for(int i=0; i<N; i++){
		        for(int j=0; j<=i; j++){
		            if(j==i)
		                a[i,j] = 0;
		            else
		                a[i,j] = a[j,i];
		        }
		    }
		    
		    cost = a;
			
		    for(int i=0;i< N;i++)
		    {
		        dist[i] = INF;
		        prev[i] = -1;
		    }
		    start = source;
		    selected[start]=1;
		    dist[start] = 0;
		    while(selected[target] ==0)
		    {
		        MIN = INF;
		        m = 0;
		        for(int i=0;i< N;i++)
		        {
		            d = dist[start] + cost[start,i];
		            if(d< dist[i]&&selected[i]==0)
		            {
		                dist[i] = d;
		                prev[i] = start;
		            }
		            if(MIN>dist[i] && selected[i]==0)
		            {
		                MIN = dist[i];
		                m = i;
		            }
		        }
		        start = m;
		        selected[start] = 1;
		    }
		    start = target;
		    return dist[target];
		}
		
		void printPath()
		{
		    j = 0;
		    while(start != -1)
		    {
		        path[j++] = start;
		        start = prev[start];
		    }
		    for(int i=j-1;i>=0;i--){
		    	lv_path.Items.Add(node[path[i]]);
		    }
		}
	}
}