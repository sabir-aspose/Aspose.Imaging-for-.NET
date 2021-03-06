Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ExportImageToDifferentFormats
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            ' ExStart:ExportImageToDifferentFormats
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing image (of type Gif) in an instance of the Image class
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("sample.gif"))
                ' Export to BMP file format using the default options
                image__1.Save(dataDir & Convert.ToString("_output.bmp"), New BmpOptions())

                ' Export to JPEG file format using the default options
                image__1.Save(dataDir & Convert.ToString("_output.jpeg"), New JpegOptions())

                ' Export to PNG file format using the default options
                image__1.Save(dataDir & Convert.ToString("_output.png"), New PngOptions())

                ' Export to TIFF file format using the default options
                image__1.Save(dataDir & Convert.ToString("_output.tiff"), New TiffOptions(TiffExpectedFormat.[Default]))
            End Using
            ' ExStart:ExportImageToDifferentFormats
            ' Display Status.
            Console.WriteLine("Conversion performed successfully.")
        End Sub
    End Class
End Namespace
