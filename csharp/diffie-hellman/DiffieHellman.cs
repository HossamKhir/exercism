using System;
using System.Numerics;

public static class DiffieHellman
{
    public static BigInteger PrivateKey(BigInteger primeP) => new (Random.Shared.NextInt64(1, (long)primeP));
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     byte[] buffer = new byte[16];
    //     Random rnd = new Random();
    //     rnd.NextBytes(buffer);
    //     BigInteger key = BigInteger.Abs(new BigInteger(buffer));
    //     BigInteger.DivRem(key, primeP - 1, out key);
    //     key += 1;
    //     return key;
    // }

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => BigInteger.ModPow(primeG, privateKey, primeP);
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => BigInteger.ModPow(publicKey, privateKey, primeP);
    // {
    //     throw new NotImplementedException("You need to implement this function.");
    // }
}