namespace AlgoritmoEstendidoEuclides
{
    public partial class fm_euclides : Form
    {
        public fm_euclides()
        {
            InitializeComponent();
        }

        // Coeficientes da combina��o linear (a�s + b�t = mdc)
        int s, t;

        // Calcula o MDC entre a e b usando o Algoritmo de Euclides Estendido
        // e define os coeficientes s e t da combina��o linear: a�s + b�t = mdc(a, b)
        int combinacaoLinear(int a, int b)
        {
            if (b == 0)
            {
                s = 1;
                t = 0;
                return a;
            }

            // Chamada recursiva trocando a e b, e reduzindo b (divis�o Euclidiana)
            int resultado = combinacaoLinear(b, a % b);

            // Atualiza os coeficientes com base nos valores anteriores
            int tempS = s;
            s = t;
            t = tempS - (a / b) * t;

            return resultado;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int numa, numb, quoc, resto;
            resto = 1;
            ltx_resultado.Items.Clear(); // Limpa os passos anteriores

            // Define numa como o maior e numb como o menor entre os dois n�meros informados
            numa = Math.Max(int.Parse(num_a.Text), int.Parse(num_b.Text));
            numb = Math.Min(int.Parse(num_a.Text), int.Parse(num_b.Text));

            // Guarda os valores originais para exibir depois
            int a = numa;
            int b = numb;

            // Calcula o MDC e os coeficientes da combina��o linear
            int combLinear = combinacaoLinear(a, b);

            // Executa o algoritmo de Euclides para encontrar o MDC
            // e exibir os passos intermedi�rios
            while (resto != 0)
            {
                quoc = numa / numb;
                resto = numa % numb;

                // Mostra o passo atual no formato: A = B � Q + R
                ltx_resultado.Items.Add($"{numa} = {numb} � {quoc} + {resto}");

                numa = numb;
                numb = resto;
            }

            // Exibe o MDC final ap�s o t�rmino da repeti��o
            ltx_resultado.Items.Add($"MDC({num_a.Text}, {num_b.Text}) = {numa}");

            // Exibe a combina��o linear correspondente
            ltx_resultado.Items.Add("Combina��o Linear:");

            // Formata a exibi��o da combina��o linear, ajustando o sinal do segundo termo
            if (t >= 0)
                ltx_resultado.Items.Add($"{combLinear} = {s} � {a} + {t} � {b}");
            else
                ltx_resultado.Items.Add($"{combLinear} = {s} � {a} - {Math.Abs(t)} � {b}");
        }
    }
}