using System;

namespace Lab4;

class ContaCorrente{
    private decimal saldo;

    public ContaCorrente(decimal val){
        saldo = val;
    }
    
    public void Depositar(decimal val){
        saldo += val;
    }

    public void Sacar(decimal val){
        saldo -= val;
    }

    public decimal Saldo {
        get {return saldo;}
    }
}