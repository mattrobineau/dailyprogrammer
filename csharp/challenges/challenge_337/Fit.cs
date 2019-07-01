using System;

namespace challenge_337
{
    public static class Fit
    {
        public static int FitBoxes(int crateX, int crateY, int boxX, int boxY)
        {
            return (crateX / boxX) * (crateY / boxY);
        }

        public static int RotatedFit(int crateX, int crateY, int boxX, int boxY)
        {
            var first = FitBoxes(crateX, crateY, boxX, boxY);
            var second = FitBoxes(crateX, crateY, boxY, boxX);

            return first > second ? first : second;
        }

        public static int FitBoxes(int crateX, int crateY, int crateZ, int boxX, int boxY, int boxZ)
        {
            return (crateX / boxX) * (crateY / boxY) * (crateZ / boxZ);
        }

        public static int RotatedFit(int crateX, int crateY, int crateZ, int boxX, int boxY, int boxZ)
        {
            var count = 0;
            count = count > FitBoxes(crateX, crateY, crateZ, boxX, boxY, boxZ) ? count : FitBoxes(crateX, crateY, crateZ, boxX, boxY, boxZ);
            count = count > FitBoxes(crateX, crateY, crateZ, boxX, boxZ, boxY) ? count : FitBoxes(crateX, crateY, crateZ, boxX, boxZ, boxY);
            count = count > FitBoxes(crateX, crateY, crateZ, boxZ, boxX, boxY) ? count : FitBoxes(crateX, crateY, crateZ, boxZ, boxX, boxY);
            count = count > FitBoxes(crateX, crateY, crateZ, boxZ, boxY, boxX) ? count : FitBoxes(crateX, crateY, crateZ, boxZ, boxY, boxX);
            count = count > FitBoxes(crateX, crateY, crateZ, boxY, boxX, boxZ) ? count : FitBoxes(crateX, crateY, crateZ, boxY, boxX, boxZ);
            count = count > FitBoxes(crateX, crateY, crateZ, boxY, boxZ, boxX) ? count : FitBoxes(crateX, crateY, crateZ, boxY, boxZ, boxX);

            return count;
        }

        public static int RotatedFit(int[] crateDimensions, int[] boxDimensions)
        {
            var canFit = 0;
            for(var i = 0; i < boxDimensions.Length; i++)
            {
                var count = FitBoxes(crateDimensions, boxDimensions);
                if(canFit < count)
                {
                    canFit = count;
                }

                Shift(boxDimensions, 1);
            }

            return canFit;
        }

        public static int FitBoxes(int[] crateDimensions, int[] boxDimensions)
        {
            if (crateDimensions.Length != boxDimensions.Length)
                return 0;

            var boxCount = 1;

            for (var i = 0; i < crateDimensions.Length; i++)
            {
                boxCount *= crateDimensions[i] / boxDimensions[i];
            }

            return boxCount;
        }

        public static int[] Shift(int[] arr, int shift)
        {
            shift = shift < 0 ? arr.Length - shift : shift;
            shift %= arr.Length;
            int[] buffer = new int[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);

            return arr;
        }
    }
}
