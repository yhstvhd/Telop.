using System.Windows;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Interop;
using System;
using System.Windows.Media.Imaging;

namespace Moddel
{
    /// <summary>
    /// 縁取りテキスト画像を作成
    /// </summary>
    class DrawFacingText
    {
        public static Bitmap Draw (string TelopText)
        {

            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(1900, 70);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //GraphicsPathオブジェクトの作成
            System.Drawing.Drawing2D.GraphicsPath gp =
                new System.Drawing.Drawing2D.GraphicsPath();
            //GraphicsPathに文字列を追加する
            System.Drawing.FontFamily ff = new System.Drawing.FontFamily("ＭＳ Ｐゴシック");
            gp.AddString(TelopText, ff, 1, 50, new System.Drawing.Point(0, 0), StringFormat.GenericDefault);
            System.Drawing.Pen drawPen = new System.Drawing.Pen(System.Drawing.Color.Black, 2.0F);

            //文字列の中を塗りつぶす
            g.FillPath(System.Drawing.Brushes.White, gp);
            //文字列の縁を描画する
            g.DrawPath(drawPen, gp);

            //リソースを解放する
            ff.Dispose();
            g.Dispose();
            return canvas;
        }
    }
}

