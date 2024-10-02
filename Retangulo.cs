public class Retangulo
{
    double altura;
    double largura;
    public Retangulo()
    {
        altura = 0;
        largura = 0;
    }
    public Retangulo(double altura, double largura)
    {
        this.altura = altura;
        this.largura = largura;
    }
    public Retangulo(double lado)
    {
        largura = lado;
        altura= lado;
    }
    public double CalcularArea()
    {
        return altura * largura;
    }
    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }
    public void Redimensionar(double NovaLargura, double NovaAltura)
    {
        largura = NovaLargura;
        altura = NovaAltura;
    }
    public void Redimensionar(double fator)
    {
        largura *= fator;
        altura *= fator;
    }
    public void Redimensionar()
    {
    }
}