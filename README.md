HTML Renderer [![Build status](https://ci.appveyor.com/api/projects/status/cm8xpf8ebt3hyi3e)](https://ci.appveyor.com/project/ArthurHub/html-renderer)
=============

A fork of [ArthurHub/HTML-Renderer](https://github.com/ArthurHub/HTML-Renderer) updated to .NET Standard / .NET 6.0.

Where possible, the assemblies target .NET Standard 2.0:
- HtmlRenderer
- HtmlRenderer.PdfSharpCore

and .NET 6.0 otherwise:
- HtmlRenderer.WinForms
- HtmlRenderer.WPF

Note that the code now depends upon [PdfSharpCore](https://github.com/ststeiger/PdfSharpCore) rather than [PdfSharp](https://github.com/empira/PDFsharp).
