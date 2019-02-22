﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloquinhos
{
    /// <summary>
    /// Classe que representa um nó dentro de um grafo.
    /// </summary>
    [Serializable]
    public class Node
    {

        #region Propriedades
        /// <summary>
        /// Indica se o nó foi visitado.
        /// </summary>
        public bool Visited { get; set; }
        /// <summary>
        /// O nó anterior no caminho.
        /// </summary>
        public Node Parent { get; set; }
        /// <summary>
        /// O nome do nó dentro do grafo.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A informação adicional armazenada no nó.
        /// </summary>
        public object Info { get; set; }
        /// <summary>
        /// A informação adicional armazenada no nó.
        /// </summary>
        public object Info_2 { get; set; }
        /// <summary>
        /// A lista de arcos associada ao nó.
        /// </summary>
        public List<Edge> Edges { get; private set; }
       
        public bool Giro_Ant { get; set; }
        public bool Giro_Hora { get; set; }

        public int Nivel { get; set; }

        public int Cont_Giros { get; set; }

        public int Cont_Blocos { get; set; }
        #endregion

        #region Construtores

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        public Node()
        {
            this.Edges = new List<Edge>();
            this.Cont_Giros = 0;
        }

        /// <summary>
        /// Cria um novo nó.
        /// </summary>
        /// <param name="name">O nome do nó.</param>
        /// <param name="info">A informação armazenada no nó.</param>
        public Node(string name, object info, object info_2, int nivel) : this()
        {
            this.Name = name;
            this.Info = info;
            this.Info_2 = info_2;
            this.Nivel = nivel;
        }

        public Node(string name, object info) : this()
        {
            this.Name = name;
            this.Info = info;
            
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        public void AddEdge(Node to)
        {
            AddEdge(to, 0);
        }

        /// <summary>
        /// Adiciona um arco com nó origem igual ao nó atual, e destino e custo de acordo com os parâmetros.
        /// </summary>
        /// <param name="to">O nó destino.</param>
        /// <param name="cost">O custo associado ao arco.</param>
        public void AddEdge(Node to, double cost)
        {
            this.Edges.Add(new Edge(this, to, cost));
        }

        #endregion

        #region Métodos Sobrescritos

        /// <summary>
        /// Apresenta a visualização do objeto em formato texto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (this.Info != null)
            {
                return String.Format("{0}({1})", this.Name, this.Info);
            }
            return this.Name;
        }

        #endregion

    }
}
