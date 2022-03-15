using System;
using OpenCvSharp;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// open jpg image file using opencvsharp

// using (var img = new Mat(@"C:\src\reactors\GitHubCoPilotCSharp\Demo03\bruno capuano.jpg", ImreadModes.Color))
// {
//     // show image in the output window
//     Cv2.ImShow("image", img);
//     Cv2.WaitKey(0);
// }

var img = new Mat(@"C:\src\reactor\GitHubCoPilotCSharp\Demo03\bruno capuano.jpg", ImreadModes.Color);
Cv2.ImShow("image", img);

var imgBg = new Mat(@"C:\src\reactor\GitHubCoPilotCSharp\Demo03\bruno capuano.jpg", ImreadModes.Grayscale);
Cv2.ImShow("image bg", imgBg);

// apply effect to img
Cv2.CvtColor(img, imgBg, ColorConversionCodes.BGR2GRAY);
Cv2.ImShow("image 2", img);
Cv2.ImShow("image bg2", imgBg);

// show image in the output window


Cv2.WaitKey(0);

