﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenCvSharp.CPlusPlus;

namespace OpenCvSharp.Tests.Face
{
    [TestFixture]
    public class LBPHFaceRecognizerTest : TestBase
    {
        [Test]
        public void CreateAndDispose()
        {
            var recognizer = FaceRecognizer.CreateLBPHFaceRecognizer(1, 8, 8, 8, 123);
            recognizer.Dispose();
        }

        [Test, Ignore("not implemented")]
        public void TrainAndPredict()
        {
            var image = Image("Lenna.png");

            var model = FaceRecognizer.CreateLBPHFaceRecognizer();

            var cascade = new CascadeClassifier("../haarcascade_frontalface_default.xml");
            var rects = cascade.DetectMultiScale(image);

            foreach (Rect rect in rects)
            {
                using (Mat face = image[rect].Clone())
                {
                    Cv2.Resize(face, face, new Size(256, 256));

                    int label;
                    double confidence;
                    model.Predict(face, out label, out confidence);
                    Console.WriteLine($"{label} ({confidence})");
                }
            }
        }
    }
}

