using primer_parcial_unit_test_procesador_matematico;
namespace TestProcesadorMatematico
{
    public class TestProcesadorMatematico
    {
        [Fact]
        public void sumar_dosNumerosEnteros_sumaDeDosNumerosEnteros()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();
            

            Assert.Equal(9, procesadorMatematico.mostrarResultado());
        }
        
        [Fact]
        public void dividir_dosNumerosEnteros_divisionDeDosNumerosEnteros()
        {
            
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            procesadorMatematico.Dividir(20, 2);

            Assert.Equal(10, procesadorMatematico.mostrarResultado());
        }
        [Fact]
        public void esNegativo_resultadoDeCuenta_boolean()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            procesadorMatematico.Dividir(20, 2);


            Assert.Equal(false, procesadorMatematico.mostrarResultado().EsNegativo());
        }
        public void calcularMayor_dosEnteros_devuelveCualEsMayor()
        {
            ProcesadorMatematico procesadorMatematico = new ProcesadorMatematico();

            procesadorMatematico.CalcularMayor(20, 2);

            Assert.Equal(20, procesadorMatematico.mostrarResultado());
        }

    }
}