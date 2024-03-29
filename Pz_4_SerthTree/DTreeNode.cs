﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pz_4_SerthTree
{
    class DTreeNode
    {
        private int info; // информационное поле
        private int key; // поле ключа
        private DTreeNode left; // ссылка на левое поддерево
        private DTreeNode right; // ссылка на правое поддерево
        public int Info { get; set; } // свойства
        public int Key { get; set; }
        public DTreeNode Left { get; set; }
        public DTreeNode Right { get; set; }
        public DTreeNode() { } // конструкторы
        public DTreeNode(int info, int key)
        {
            Info = info; Key = key;
        }
        public DTreeNode(int info, int key, DTreeNode left, DTreeNode right)
        {
            Info = info; Key = key; Left = left; Right = right;
        }
    }
}
