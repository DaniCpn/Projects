using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jeu_de_la_vie
{
    class Grille
    {
        #region Attributes
        private Cellule[,] grid_;
        private int height_;
        #endregion

        #region Constructors
        public Grille(int height)
        {
            this.height_ = height;
            grid_ = new Cellule[height, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    grid_[i, j] = new Cellule(1, i, j);
                }
            }
        }

        public Grille(int height, int percentage)
        {
            Random rand = new Random();
            int aliveCells = (int)((height * height) * ((float)percentage / 100));
            int madeAlive = 0;

            this.height_ = height;
            grid_ = new Cellule[height, height];
            do
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (grid_[i, j] == null)
                        {
                            grid_[i, j] = new Cellule(1, i, j, Type.NONE);
                        }
                        else if (rand.Next(0, 100) < percentage && madeAlive < aliveCells && grid_[i, j].type != Type.ALIVE)
                        {
                            grid_[i, j] = new Cellule(1, i, j, Type.ALIVE);
                            madeAlive++;
                        }
                    }
                }
            } while (madeAlive < aliveCells);
        }

        public Grille(int height, int percentage, string libelle, int age, int energy)
        {
            Random rand = new Random();
            int aliveCells = (int)((height * height) * ((float)percentage / 100));
            int madeAlive = 0;

            this.height_ = height;
            grid_ = new Cellule[height, height];
            do
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (grid_[i, j] == null)
                        {
                            grid_[i, j] = new Cellule(2, i, j, Type.NONE, age, energy, libelle);
                        }
                        else if (rand.Next(0, 100) < percentage && madeAlive < aliveCells && grid_[i, j].type != Type.ALIVE)
                        {
                            grid_[i, j] = new Cellule(2, i, j, Type.ALIVE, age, energy, libelle);
                            madeAlive++;
                        }
                    }
                }
            } while (madeAlive < aliveCells);
        }

        public Grille(string file)
        {
            string[] txt = File.ReadAllLines(file);
            int height = txt.Length;
            Type type = Type.ALIVE;

            this.height_ = height;
            grid_ = new Cellule[height, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    type = Type.ALIVE;
                    if (txt[i][j] == '0')
                        type = Type.NONE;
                    grid_[i, j] = new Cellule(1, i, j, type);
                }
            }
        }
        #endregion

        #region Getter & Setter
        public int height
        {
            get { return height_; }
        }
        #endregion

        #region Methods
        public void traversal(Grille temp)
        {
            for (int i = 0; i < height_; i++)
            {
                for (int j = 0; j < height_; j++)
                {
                    if (grid_[0, 0].level == 1)
                    {
                        grid_[i, j].neighbours = getNeighbours(i, j);
                        ruleLevel1(grid_[i, j], temp.grid_[i, j]);
                    }
                    else
                    {
                        grid_[i, j].neighbours = getNeighbours(i, j);
                        ruleLevel2(grid_[i, j], temp);
                    }
                }
            }
            Clone(temp);
        }

        public uint getNeighbours(int i, int j)
        {
            uint neighboursNum = 0;

            for (int k = i - 1; k < i + 2; k++)
            {
                for (int l = j - 1; l < j + 2; l++)
                {
                    if (grid_[(k + height_) % height_, (l + height_) % height_].type == Type.ALIVE)
                    {
                        if (k != i || l != j)
                            neighboursNum++;
                    }
                }
            }
            return neighboursNum;
        }

        public void life()
        {
            foreach (Cellule myCell in grid_)
            {
                if (myCell.type == Type.ALIVE)
                {
                    myCell.energy += 4;
                    myCell.age++;
                }
            }
        }

        public void Clone(Grille grillec)
        {
            for (int i = 0; i < height_; i++)
            {
                for (int j = 0; j < height_; j++)
                {
                    this.grid_[i, j].Clone(grillec.grid_[i, j]);
                }
            }
        }

        public void ecritureGrille(string file)
        {
            FileStream inf = new FileStream(file, FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(inf, Encoding.ASCII);
            for (int i = 0; i < height_; i++)
            {
                for (int j = 0; j < height_; j++)
                {
                    if (grid_[i, j].type == Type.ALIVE)
                        writer.Write('1');
                    else
                        writer.Write('0');
                }
                writer.Write('\n');
            }
            writer.Close();
            inf.Close();
        }
        #endregion

        #region Changes

        public void ruleLevel1(Cellule myCell, Cellule tempCell)
        {
            tempCell.Clone(jeuNiveau1(myCell, (int)myCell.neighbours));
        }

        public Cellule jeuNiveau1(Cellule myCell, int neighbours)
        {
            Cellule temp = new Cellule(1, myCell.x, myCell.y);
            if (myCell.type == Type.ALIVE)
            {
                switch (neighbours)
                {
                    case 2:
                        temp.type = Type.ALIVE;
                        break;
                    case 3:
                        temp.type = Type.ALIVE;
                        break;
                    default:
                        temp.type = Type.NONE;
                        break;
                }
            }
            else
            {
                if (neighbours == 3)
                {
                    temp.type = Type.ALIVE;
                }
            }
            return temp;
        }

        public Cellule oldDeath(Cellule myCell, Cellule tempCell)
        {
            if (myCell.age >= 5)
            {
                tempCell.type = Type.NONE;
                tempCell.age = 0;
                tempCell.energy = 1;
            }
            return tempCell;
        }

        public bool isReproduced(Cellule temp)
        {
            bool repro = false;
            int i = temp.x, j = temp.y;
            int k = i - 1, l = j - 1;
            for (k = i - 1; k < i + 2; k++)
            {
                if (repro == true)
                    break;
                for (l = j - 1; l < j + 2; l++)
                {
                    if (repro == true)
                        break;
                    repro = grid_[(k + height_) % height_, (l + height_) % height_].energy >= 10 && grid_[(k + height_) % height_, (l + height_) % height_].type == Type.ALIVE;
                    if (repro == true)
                        break;
                }
                if (repro == true)
                    break;
            }
            return repro;
        }

        public Cellule reproduction(Cellule temp)
        {
            if (isReproduced(temp))
            {
                temp = new Cellule(2, temp.x, temp.y, Type.ALIVE, 0, 1, "V");
            }
            return temp;
        }

        public Cellule reduceEnergy(Cellule temp)
        {
            if (temp.energy >= 10 && temp.neighbours < 8)
            {
                temp.energy -= 10;
            }
            return temp;
        }

        public void ruleLevel2(Cellule myCell, Grille tempGrid)
        {
            tempGrid.grid_[myCell.x, myCell.y].Clone(jeuNiveau2(myCell, (int)myCell.neighbours));
        }

        public Cellule jeuNiveau2(Cellule myCell, int neighbours)
        {
            Cellule temp = new Cellule(2, myCell.x, myCell.y, myCell.type, myCell.age, myCell.energy, myCell.libelle);

            if (myCell.type == Type.ALIVE)
            {
                temp.Clone(myCell);
                switch (neighbours)
                {
                    case 2:
                        temp = oldDeath(myCell, temp);
                        temp = reduceEnergy(temp);
                        break;
                    case 3:
                        temp = oldDeath(myCell, temp);
                        temp = reduceEnergy(temp);
                        break;
                    default:
                        temp.type = Type.NONE;
                        break;
                }
            }
            else
            {
                if (neighbours == 3)
                {
                    temp.type = Type.ALIVE;
                    temp.age = 0;
                    temp.energy = 1;
                }
                temp = reproduction(temp);
            }
            return temp;
        }
        #endregion

        #region Display
        public void afficheGrille(string message)
        {
            for (uint i = 0; i < height_; i++)
            {
                for (uint j = 0; j < height_; j++)
                {
                    grid_[i, j].affiche();
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Voisin
        public Cellule VoisinNord(Cellule macase)
        {
            return grid_[macase.x, (macase.y - 1 + height_) % height_];
        }

        public Cellule VoisinNordEst(Cellule macase)
        {
            return grid_[(macase.x + 1 + height_) % height_, (macase.y - 1 + height_) % height_];
        }

        public Cellule VoisinNordOuest(Cellule macase)
        {
            return grid_[(macase.x - 1 + height_) % height_, (macase.y - 1 + height_) % height_];
        }

        public Cellule VoisinSud(Cellule macase)
        {
            return grid_[macase.x, (macase.y + 1 + height_) % height_];
        }

        public Cellule VoisinSudEst(Cellule macase)
        {
            return grid_[(macase.x + 1 + height_) % height_, (macase.y + 1 + height_) % height_];
        }

        public Cellule VoisinSudOuest(Cellule macase)
        {
            return grid_[(macase.x - 1 + height_) % height_, (macase.y + 1 + height_) % height_];
        }

        public Cellule VoisinOuest(Cellule macase)
        {
            return grid_[(macase.x - 1 + height_) % height_, macase.y];
        }

        public Cellule VoisinEst(Cellule macase)
        {
            return grid_[(macase.x + 1 + height_) % height_, macase.y];
        }
        #endregion
    }
}