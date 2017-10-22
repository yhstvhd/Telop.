
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Telops
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
			
			string TelopText = "テスト";
			
			//描画先とするImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(200, 200);
			//ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g = Graphics.FromImage(canvas);

			//GraphicsPathオブジェクトの作成
			System.Drawing.Drawing2D.GraphicsPath gp =
				new System.Drawing.Drawing2D.GraphicsPath();
			//GraphicsPathに文字列を追加する
			FontFamily ff = new FontFamily("ＭＳ Ｐゴシック");
			gp.AddString(TelopText, ff, 1, 50,new System.Drawing.Point(0, 0), StringFormat.GenericDefault);
			Pen drawPen = new Pen(Color.Black, 2.0F);

			//文字列の中を塗りつぶす
			g.FillPath(Brushes.White, gp);
			//文字列の縁を描画する
			g.DrawPath(drawPen, gp);

			//リソースを解放する
			ff.Dispose();
			g.Dispose();
			
			image.Source = canvas;
		}
	}
}