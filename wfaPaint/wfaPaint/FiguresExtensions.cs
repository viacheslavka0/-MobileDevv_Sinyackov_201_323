using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPaint;
public static class FiguresExtensions
{
    public static void DrawTriangle(this Graphics g, Pen pen, Rectangle rect)
        => g.DrawPolygon(pen, GetTrianglePoints(rect));

    public static void FillTriangle(this Graphics g, Brush brush, Rectangle rect)
        => g.FillPolygon(brush, GetTrianglePoints(rect));
    

    private static Point[] GetTrianglePoints(Rectangle rect)
    {
        var p1 = new Point(rect.Left, rect.Y);
        var p2 = new Point(rect.Right, rect.Y);
        var p3 = new Point(rect.Left + rect.Width / 2, rect.Bottom);

        return new Point[] { p1, p2, p3 };
    }


    public static void DrawArrow(this Graphics g, Pen pen, Rectangle rect)
        => g.DrawPolygon(pen, GetArrowPoints(rect));

    public static void FillArrow(this Graphics g, Brush brush, Rectangle rect)
        => g.FillPolygon(brush, GetArrowPoints(rect));

    private static Point[] GetArrowPoints(Rectangle rect)
    {
        var arrowHeight = rect.Y + (int)(rect.Height * 0.25f);
        var xMiddle = rect.Left + rect.Width / 2;
        var yMiddle = rect.Y + rect.Height / 2;

        var pLeftUp = new Point(rect.Left, arrowHeight);
        var pMiddleUp = new Point(xMiddle, pLeftUp.Y);
        var pArrowUp = new Point(xMiddle, rect.Y);

        var pRight = new Point(rect.Right, yMiddle);

        var pArrowDown = new Point(pArrowUp.X, 2 * pRight.Y - pArrowUp.Y);
        var pMiddleDown = new Point(pMiddleUp.X, 2 * pRight.Y - pMiddleUp.Y);
        var pLeftDown = new Point(pLeftUp.X, 2 * pRight.Y - pLeftUp.Y);

        return new Point[] { pLeftUp, pMiddleUp, pArrowUp, pRight, pArrowDown, pMiddleDown, pLeftDown };
    }


    public static void DrawHexagon(this Graphics g, Pen pen, Rectangle rect)
        => g.DrawPolygon(pen, GetHexagonPoints(rect));

    public static void FillHexagon(this Graphics g, Brush brush, Rectangle rect)
        => g.FillPolygon(brush, GetHexagonPoints(rect));

    private static Point[] GetHexagonPoints(Rectangle rect)
    {
        var xMiddle = rect.Left + rect.Width / 2;
        var yUpMiddle = rect.Y + rect.Height / 4;
        var yDownMiddle = rect.Bottom - rect.Height / 4;

        var pUp = new Point(xMiddle, rect.Y);
        var pDown = new Point(xMiddle, rect.Bottom);

        var pLeftUp = new Point(rect.Left, yUpMiddle);
        var pLeftDown = new Point(rect.Left, yDownMiddle);

        var pRightUp = new Point(rect.Right, yUpMiddle);
        var pRightDown = new Point(rect.Right, yDownMiddle);

        return new Point[] { pLeftUp, pUp, pRightUp, pRightDown, pDown, pLeftDown };
    }
}
