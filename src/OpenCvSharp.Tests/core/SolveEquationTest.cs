﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenCvSharp.CPlusPlus;

namespace OpenCvSharp.Tests.Core
{
    [TestFixture]
    public class SolveEquationTest : TestBase
    {
        [Test]
        public void ByMat()
        {
            // x + y = 10
            // 2x + 3y = 26
            // (x=4, y=6)

            double[,] av = {{1, 1},
                          {2, 3}};
            double[] yv = { 10, 26 };

            Mat a = new Mat(2, 2, MatType.CV_64FC1, av);
            Mat y = new Mat(2, 1, MatType.CV_64FC1, yv);
            Mat x = new Mat();

            Cv2.Solve(a, y, x, MatrixDecomposition.LU);

            Console.WriteLine("X1 = {0}, X2 = {1}", x.At<double>(0), x.At<double>(1));
            Assert.That(x.At<double>(0), Is.EqualTo(4).Within(1e-6));
            Assert.That(x.At<double>(1), Is.EqualTo(6).Within(1e-6));
        }

        [Test]
        public void ByNormalArray()
        {
            // x + y = 10
            // 2x + 3y = 26
            // (x=4, y=6)

            double[,] a = {{1, 1},
                          {2, 3}};
            double[] y = { 10, 26 };

            List<double> x = new List<double>();

            Cv2.Solve(
                InputArray.Create(a), InputArray.Create(y),
                OutputArray.Create(x),
                MatrixDecomposition.LU);

            Console.WriteLine("X1 = {0}, X2 = {1}", x[0], x[1]);
            Assert.That(x[0], Is.EqualTo(4).Within(1e-6));
            Assert.That(x[1], Is.EqualTo(6).Within(1e-6));
        }
    }
}

