
namespace IMGC
{
    public static class Help
    {
        public readonly static string Text;
        static Help()
        {
            Text =
@"
IMGC is written using the Magick.Net library.

help command only prints an incomplete overview of supported image formats.
Please refer to the official documentation of the Magick.Net library for a complete overview of supported file formats and limitations.
Not all formats have been tested.

Display format:
    [Format] | [Mode] | [Description]

Mode
    R : Read supported
    W : Write supported
    RW: Read and write Supported

ART   | R  | PFS: 1st Publisher
AVI   | R  | Microsoft Audio / Visual Interleaved
AVS   | RW | AVS X image
BMP   | RW | Microsoft Windows bitmap
CGM   | R  | Computer Graphics Metafile
CMY   | RW | Raw cyan, magenta, yellow, and black samples
CUT   | R  | DR Halo
DCM   | R  | Digital Imaging and Communications in Medicine(DICOM) image
DCX   | RW | ZSoft IBM PC multi - page Paintbrush image
DIB   | RW | Microsoft Windows Device Independent Bitmap
DPX   | RW | Digital Moving Picture Exchange
EMF   | R  | Microsoft Enhanced Metafile(32 - bit)
EPDF  | RW | Encapsulated Portable Document Format
FAX   | RW | Group 3 TIFF
FITS  | RW | Flexible Image Transport System
GIF   | RW | CompuServe Graphics Interchange Format
GRAY  | RW | Raw gray samples
HEIC  | R  | High Efficiency Image Codec, used by apple for storing camera photos on iPhones
HTML  | RW | Hypertext Markup Language with a client - side image map
ICO   | R  | Microsoft icon
JPEG  | RW | Joint Photographic Experts Group JFIF format
JPG   | RW | Joint Photographic Experts Group JFIF format
MAT   | R  | MATLAB image format
MIFF  | RW | Magick image file format
MONO  | RW | Bi - level bitmap in least - significant - byte first order
MPC   | RW | Magick Persistent Cache image file format
MTV   | RW | MTV Raytracing image format
MVG   | RW | Magick Vector Graphics
OTB   | RW | On - the - air Bitmap
P7    | RW | Xv's Visual Schnauzer thumbnail format
PALM  | RW | Palm pixmap
PBM   | RW | Portable bitmap format(black and white)
PCD   | RW | Photo CD, max 768x512 resolution
PCDS  | RW | Photo CD, Decode with the sRGB color tables
PCL   | W  | HP Page Control Language, for output to HP laser printers
PCX   | RW | ZSoft IBM PC Paintbrush file
PDB   | RW | Palm Database ImageViewer Format
PFA   | R  | Postscript Type 1 font(ASCII), Opening as file returns a preview image
PFB   | R  | Postscript Type 1 font(binary), Opening as file returns a preview image
PGM   | RW | Portable graymap format(gray scale)
PICON | RW | Personal Icon
PICT  | RW | Apple Macintosh QuickDraw / PICT file
PIX   | R  | Alias / Wavefront RLE image format
PNG   | RW | Portable Network Graphics
PNM   | RW | Portable anymap
PPM   | RW | Portable pixmap format(color)
PSD   | RW | Adobe Photoshop bitmap file
PTIF  | RW | Pyramid encodd TIFF
PWP   | R  | Seattle File Works multi - image file
RAD   | R  | Radiance image file, Requires that ra_ppm from the Radiance software package be installed
RGB   | RW | Raw red, green, and blue samples
RGBA  | RW | Raw red, green, blue, and matte samples
RLA   | R  | Alias / Wavefront image file
RLE   | R  | Utah Run length encoded image file
SCT   | R  | Scitex Continuous Tone Picture
SFW   | R  | Seattle File Works image
SGI   | RW | IRIX RGB image
SHTML | W  | Hypertext Markup Language client - side image map
SUN   | RW | SUN Rasterfile
TGA   | RW | Truevision Targa image
TIFF  | RW | Tagged Image File Format, Also known as TIF
TIM   | R  | PSX TIM file
TXT   | RW | Raw text file
UIL   | W  | X - Motif UIL table
UYVY  | RW | Interleaved YUV raw image
VICAR | RW | VICAR rasterfile format
VIFF  | RW | Khoros Visualization Image File Format
WBMP  | RW | Wireless bitmap, Support for uncompressed monochrome only.
WPG   | R  | Word Perfect Grafics File
XBM   | RW | X Windows system bitmap, black and white only
XCF   | R  | GIMP image
XOM   | RW | X Windows system pixmap, Also known as PM
XWD   | RW | X Windows system window dump
YUV   | RW | CCIR 601 4:1:1
";
        }
    }
}