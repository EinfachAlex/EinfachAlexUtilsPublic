using System.Numerics;

namespace EinfachAlex.Utils.HashGenerator
{
    public class Hash
    {
        private readonly string hash;
        public BigInteger hashint { get; }

        private static readonly BigInteger maxhash = BigInteger.Parse("0ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff", System.Globalization.NumberStyles.HexNumber);

        public Hash(string hash)
        {
            this.hash = hash;
            this.hashint = BigInteger.Parse("0" + hash, System.Globalization.NumberStyles.HexNumber);
        }

        public bool matchesDifficulty(int difficulty)
        {
            difficulty = difficulty == 0 ? difficulty = 1 : difficulty;
            BigInteger fittingHashes = maxhash / difficulty;

            if (this.hashint < fittingHashes)
                return true;

            return false;
        }

        public static int toDifficulty(string hexHash)
        {
            BigInteger inputHash = BigInteger.Parse(hexHash, System.Globalization.NumberStyles.HexNumber);
            BigInteger difficulty = maxhash / inputHash;

            return (int) difficulty;
        }

        public double toDifficulty() => (double)maxhash / (double)this.hashint;

        public string getHashString() => this.hash;
        public override string ToString() => getHashString();
    }
}