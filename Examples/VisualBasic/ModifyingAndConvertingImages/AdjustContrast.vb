﻿Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class AdjustContrast
        Public Shared Sub Run()
            ' To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")
            ' ExStart:AdjustBrightness
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image in an instance of Image
            Using image_1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                ' Cast object of Image to RasterImage
                Dim rasterImage As RasterImage = DirectCast(image_1, RasterImage)

                ' Check if RasterImage is cached
                If Not rasterImage.IsCached Then
                    ' Cache RasterImage for better performance
                    rasterImage.CacheData()
                End If

                ' Adjust the contrast
                rasterImage.AdjustContrast(10)

                ' Create an instance of TiffOptions for the resultant image
                Dim tiffOptions As New TiffOptions(TiffExpectedFormat.[Default])
                ' Set various properties for the object of TiffOptions
                tiffOptions.BitsPerSample = New UShort() {8, 8, 8}
                tiffOptions.Photometric = TiffPhotometrics.Rgb

                ' Save the resultant image to TIFF format
                rasterImage.Save(dataDir & Convert.ToString("AdjustContrast_out.tiff"), tiffOptions)
            End Using
            ' ExEnd:TiffOptionsConfiguration
        End Sub
    End Class
End Namespace