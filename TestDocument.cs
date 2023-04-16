using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

public class TestDocument : IDocument
{
	public void Compose(IDocumentContainer container)
	{
		FontManager.RegisterFont(File.OpenRead("fonts/ComicMono.ttf"));

		container.Page(page =>
		{
			page.Size(PageSizes.A4);
			page.Margin(20);
			page.Header().PaddingBottom(20).AlignCenter().Width(300).Image("images/codiceplastico.png");

			page.Content().DefaultTextStyle(font => font.FontFamily("Comic Mono")).AlignCenter().Column(container => {
				container.Item().PaddingBottom(5).AlignCenter().Text("Primo elemento del container Column");
				container.Item().PaddingBottom(5).AlignCenter().Text("Secondo elemento del container Column");
				container.Item().PaddingBottom(5).AlignCenter().Text("Terzo elemento del container Column");

				container.Item().PaddingTop(15).AlignCenter().Row(container => {
					container.AutoItem().PaddingRight(15).Text("Primo elemento del container Row");
					container.AutoItem().Text("Secondo elemento del container Row");
				});
			});

			page.Footer().AlignRight().Text(text =>
			{
				text.Span("Pagina ");
				text.CurrentPageNumber();
				text.Span(" di ");
				text.TotalPages();
			});
		});
	}

	public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
}