using StrategyDesignPattern;

PaymentOperation paymentOperation = null;

int payment=2;



if(payment == (int)PaymentType.Cash)
{
    paymentOperation = new PaymentOperation(new CashOrderPayment());
}
else if(payment == (int)PaymentType.PayPal)
{
    paymentOperation = new PaymentOperation(new PayPalOrderPayment());
}
else
{
    paymentOperation = new PaymentOperation(new EftOrderPayment());
}

paymentOperation.MakePayment();