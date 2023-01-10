using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LabyrinthGenerator
{
    class Program
    {
        public struct LabyrinthCell
        {
            public bool rightWall, bottomWall;
            public int host; // множество, к которому принадлежит ячейка

            public LabyrinthCell(bool hasRightWall, bool hasBottomWall, int hostNumber)
            {
                rightWall = hasRightWall;
                bottomWall = hasBottomWall;
                host = hostNumber;
            }
        }

        static int labyrinthWidth = 35;
        static int labyrinthHeight = 35;

        static Random rnd = new Random();
        static int rightWallProbability = 50;   // вероятности генерации стен
        static int bottomWallProbability = 50;

        static LabyrinthCell[] labyrinthLine = new LabyrinthCell[labyrinthWidth];

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            labyrinthLine = new LabyrinthCell[labyrinthWidth];
            PrintCap();
            GenerateNullLine();
           for (int i = 0; i < labyrinthHeight - 1; i++)
            {
                HostCells();
                GenerateRightWalls();
                GenerateBottomWalls();
                PrintLine();
                RemoveAllRightWalls();
                ClearCellsWithBottomWall();
            }
            HostCells();
            GenerateRightWalls();
            GenerateBottomWalls();
            GenerateLastLine();
            PrintLine();

            Console.ReadLine();
        }

        static void GenerateNullLine()
        {
            // генерирует строку пустых ячеек без границ, не принадлежащих никакому множеству
            labyrinthLine = new LabyrinthCell[labyrinthWidth];

            for (int i = 0; i < labyrinthWidth; i++)
            {
                LabyrinthCell cell = new LabyrinthCell(false, false, -1);
                labyrinthLine[i] = cell;
            }
        }

        static void HostCells()
        {
            // присваивает ячейкам, не входящим в множество, свое уникальное множество
            int hostNew = 0;
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].host == -1)
                {
                    while (!HostIsFree(hostNew))
                    {
                        hostNew++;
                    }
                    labyrinthLine[i].host = hostNew;
                }
            }
        }

        static bool HostIsFree(int hostNumber)
        {
            // проверяет, свободно ли имя множества
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].host == hostNumber)
                    return false;
            }
            return true;
        }

        static void GenerateRightWalls()
        {
            // случайным образом добавляет правые стенки к ячейкам
            int gen = 0;
            int genPrev = 0;
            for (int i = 0; i < labyrinthLine.Length - 1; i++)
            {
                if (labyrinthLine[i].host == labyrinthLine[i + 1].host)
                {
                    labyrinthLine[i].rightWall = true;
                    continue;
                }
                //Thread.Sleep(10);
                gen = rnd.Next(100);
                if (gen == genPrev)
                {
                    i--;
                    continue;
                }
                genPrev = gen;
                if (gen > (100 - rightWallProbability))
                {
                    labyrinthLine[i].rightWall = true;
                }
                else
                {
                    labyrinthLine[i + 1].host = labyrinthLine[i].host;
                }
            }
        }

        static void GenerateBottomWalls()
        {
            // случаным образом генерирует нижние стенки к ячейкам
            int gen = 0;
            int genPrev = 0;
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                int count = GetCellCountInHost(i);
                if (count == 1)
                    continue;
                count = GetNumberOfBottomlessCellsInHost(labyrinthLine[i].host);
                if (count == 1)
                    continue;

                if (HasBottomlessBefore(i))
                {
                    labyrinthLine[i].bottomWall = true;
                    continue;
                }
                //Thread.Sleep(10);
                gen = rnd.Next(100);
                if (gen == genPrev)
                {
                    i--;
                    continue;
                }
                genPrev = gen;
                if (gen > (100 - bottomWallProbability))
                {
                    labyrinthLine[i].bottomWall = true;
                }
            }
        }

        static int GetCellCountInHost(int indexInLine)
        {
            // возвращает кол-во ячеек, принадлежащих данному множеству
            // indexInLine - номер ячейки в строке, множество которой нужно проверить
            int hostNumber = labyrinthLine[indexInLine].host;
            int count = 0;
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].host == hostNumber)
                {
                    count++;
                }
            }
            return count;
        }

        static int GetNumberOfBottomlessCellsInHost(int hostNumber)
        {
            // возвращает кол-во ячеек в данном множестве, не имеющих нижней стенки
            int count = 0;
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].host == hostNumber)
                {
                    if (!labyrinthLine[i].bottomWall)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static bool HasBottomlessBefore(int indexInLine)
        {
            for (int i = 0; i < indexInLine; i++)
            {
                if (labyrinthLine[i].host == labyrinthLine[indexInLine].host)
                {
                    if (!labyrinthLine[i].bottomWall)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void RemoveAllRightWalls()
        {
            // удаляет все правые стенки
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].rightWall)
                    labyrinthLine[i].rightWall = false;
            }
        }

        static void ClearCellsWithBottomWall()
        {
            // удаляет ячейки с нижними стенками из их множества
            // и удаляет сами нижние стенки
            for (int i = 0; i < labyrinthLine.Length; i++)
            {
                if (labyrinthLine[i].bottomWall)
                {
                    labyrinthLine[i].bottomWall = false;
                    labyrinthLine[i].host = -1;
                }
            }
        }

        static void GenerateLastLine()
        {
            for (int i = 0; i < labyrinthLine.Length - 1; i++)
            {
                //labyrinthLine[i].rightWall = true;
                labyrinthLine[i].bottomWall = true;
                if (labyrinthLine[i].host != labyrinthLine[i + 1].host)
                {
                    labyrinthLine[i].rightWall = false;
                    //labyrinthLine[i + 1].host = labyrinthLine[i].host;
                }
            }
            labyrinthLine[labyrinthLine.Length - 1].bottomWall = true;
        }

        static void PrintCap()
        {
            Console.Write("\n.");
            for (int i = 0; i < labyrinthLine.Length - 1; i++)
            {
                Console.Write("__");
            }
            Console.Write("_.");
        }

        static void PrintLine()
        {
            Console.Write("\n|");
            for (int i = 0; i < labyrinthLine.Length - 1; i++)
            {
                if (labyrinthLine[i].bottomWall)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(" ");
                }
                if (labyrinthLine[i].rightWall)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            if (labyrinthLine[labyrinthLine.Length - 1].bottomWall)
            {
                Console.Write("_");
            }
            else
            {
                Console.Write(" ");
            }
            Console.Write("|");
        }
    }
}