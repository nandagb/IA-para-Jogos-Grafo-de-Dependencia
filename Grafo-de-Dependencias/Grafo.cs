using System;


    
    class Grafo {
        private int[][] matrizAdjacencia;
        
        private int n_nos = 0;

        public Grafo(int n) {
            this.n_nos = n;
            matrizAdjacencia = new int[n][];
            for (int i = 0; i < n; i++){
                matrizAdjacencia[i] = new int[n];
            }
            
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    this.matrizAdjacencia[i][j] = 0;
                }
            }
        }


        public void addDependencia(int n1, int n2) {
            this.matrizAdjacencia[n1][n2] = 1;
        }

        public void removeDependecia(int n1, int n2) {
            this.matrizAdjacencia[n1][n2] = 0;
        }

        public void imprimir() {
            Console.Write("   ");
            for(int k = 0; k < 10; k++){
                Console.Write(k + "  ");
            }
            Console.WriteLine("");
            Console.WriteLine("   ----------------------------");
            for(int i = 0; i < 10; i++){
                for(int j = 0; j < 10; j++){
                    if(j == 0) Console.Write(i + "| ");
                    Console.Write(this.matrizAdjacencia[i][j]);
                    if(j != 9) Console.Write(", ");
                    else Console.WriteLine("");
                }
            }
            Console.WriteLine("");
        }

        public bool temDependencia(int n) {
            for( int i = 0; i< 10 ; i++){
                if(this.matrizAdjacencia[i][n] == 1)
                    return true;
            }
            return false;
        }

        public List<int> verticesAdjacentes(int n) {
            List<int> adjacentes = new List<int>();
            for(int j = 0; j < 10; j++){
                if(this.matrizAdjacencia[n][j] == 1){
                    adjacentes.Add(j);
                }
            }
            return adjacentes;
        }
    }

