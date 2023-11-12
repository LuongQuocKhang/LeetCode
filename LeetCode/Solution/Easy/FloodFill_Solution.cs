using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution.Easy
{
    public class FloodFill_Solution
    {
        public static void Run()
        {

        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color) return image;
            Fill(image, sr, sc, image[sr][sc], color);

            return image;
        }


        public static void Fill(int[][] image, int sr, int sc, int color, int newColor)
        {
            if (sr < 0 || sc < 0 || sr >= image.Length || sc >= image[0].Length
                || image[sr][sc] != color)
            {
                return;
            }

            image[sr][sc] = newColor;

            Fill(image, sr - 1, sc, color, newColor);
            Fill(image, sr + 1, sc, color, newColor);
            Fill(image, sr, sc - 1, color, newColor);
            Fill(image, sr, sc + 1, color, newColor);
        }
    }
}
