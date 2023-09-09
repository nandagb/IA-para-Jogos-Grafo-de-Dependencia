using System;


    
    class Gerenciador {
        
        private Grafo grafo;        
        private List<int> verticesIndependentes = new List<int>();
        private List<int> ordem = new List<int>();

        private List<int> verticesVisitados = new List<int>();

        


        public void rodarGrafo() {
            grafo = new Grafo(10);
            this.criarGrafo();
            this.ordenacaoTopologica();
            List<int> ordemCorreta = new List<int>();
            for(int i=(ordem.Count-1); i>=0; i--){
                ordemCorreta.Add(this.ordem[i]);
            }
            
            
            Console.WriteLine("Ordem:");
            foreach(int i in ordemCorreta){
                Console.Write(i + ", ");
            }

        }

        public void criarGrafo() {
            grafo.addDependencia(0, 1);
            grafo.addDependencia(1, 5);
            grafo.addDependencia(1, 9);
            grafo.addDependencia(2, 1);
            grafo.addDependencia(3, 6);
            grafo.addDependencia(4, 3);
            grafo.addDependencia(5, 3);
            grafo.addDependencia(7, 6);
            grafo.addDependencia(8, 7);
            grafo.addDependencia(9, 3);
        }


        public void getVerticiesIndependentes() {
            for(int i = 0; i < 10; i++){
                if(!grafo.temDependencia(i)){
                    this.verticesIndependentes.Add(i);
                }
            }
        }

        public void ordenacaoTopologica() {
            this.getVerticiesIndependentes();
            foreach (int v in this.verticesIndependentes){
                this.visite(v);
            }

        }

        public void visite(int v) {
            if(!this.verticesVisitados.Contains(v)){
                this.verticesVisitados.Add(v);
                List<int> adjacentes = grafo.verticesAdjacentes(v);
                foreach(int a in adjacentes) {
                    visite(a);
                }
                this.ordem.Add(v);
            }
        }
        
    }

