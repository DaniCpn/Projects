using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie
{
    enum Type
    {
        ALIVE,
        NONE
    };

    class Cellule
    {
        #region Attributes
        // Level 1 - 2
        private int x_;
        private int y_;
        private uint level_;
        private Type type_;
        private uint neighboursNum_;
        private string libelle_;

        // Level 2
        private int energy_;
        private int age_;
        #endregion

        #region Constructor
        public Cellule(uint level, int x, int y, Type type = Type.NONE, int age = 0, int energy = 0, string libelle = "1")
        {
            this.level_ = level;
            this.type_ = type;
            this.x_ = x;
            this.y_ = y;
            neighboursNum_ = 0;
            energy_ = energy;
            age_ = age;
            libelle_ = libelle;
        }
        #endregion

        #region Getter & Setter
        public Type type
        {
            set { this.type_ = value; }
            get { return this.type_; }
        }

        public uint level
        {
            get { return level_; }
        }
        public uint neighbours
        {
            set { this.neighboursNum_ = value; }
            get { return this.neighboursNum_; }
        }

        public int age
        {
            set { this.age_ = value; }
            get { return this.age_; }
        }

        public int energy
        {
            set { this.energy_ = value; }
            get { return this.energy_; }
        }

        public int x
        {
            get { return this.x_; }
        }

        public int y
        {
            get { return this.y_; }
        }

        public string libelle
        {
            get { return libelle_; }
        }
        #endregion

        #region Methods
        public void Clone(Cellule myCell)
        {
            this.type_ = myCell.type_;
            this.neighboursNum_ = myCell.neighboursNum_;
            this.level_ = myCell.level_;
            this.age_ = myCell.age;
            this.energy_ = myCell.energy_;
            this.libelle_ = myCell.libelle;
        }

        public string toString()
        {
            string str = "";

            str += "type : " + type;
            if (level_ == 2)
            {
                str += ", " + "age : " + this.age_ + ", energy : " + this.energy_;
            }
            return str;
        }

        public void affiche()
        {
            if (type == Type.ALIVE)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(libelle_ + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("0 ");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        #endregion
    }
}
