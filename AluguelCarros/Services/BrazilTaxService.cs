﻿namespace AluguelCarros.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 02;

            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
