using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using MVC_cours_isitech.Models;

public interface IPdfService
{
    byte[] GenerateEventsPdf(List<Event> events);
    byte[] GenerateEventDetailPdf(Event evt);
}

public class PdfService : IPdfService
{
    public byte[] GenerateEventsPdf(List<Event> events)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            PdfWriter writer = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Header
            Paragraph header = new Paragraph("Liste des événements")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);

            // Create table
            Table table = new Table(4).UseAllAvailableWidth();
            
            // Add headers
            table.AddCell(new Cell().Add(new Paragraph("Titre")));
            table.AddCell(new Cell().Add(new Paragraph("Date")));
            table.AddCell(new Cell().Add(new Paragraph("Lieu")));
            table.AddCell(new Cell().Add(new Paragraph("Participants Max")));

            // Add data
            foreach (var evt in events)
            {
                table.AddCell(new Cell().Add(new Paragraph(evt.Title)));
                table.AddCell(new Cell().Add(new Paragraph(evt.EventDate.ToString("dd/MM/yyyy HH:mm"))));
                table.AddCell(new Cell().Add(new Paragraph(evt.Location)));
                table.AddCell(new Cell().Add(new Paragraph(evt.MaxParticipants.ToString())));
            }

            document.Add(table);
            document.Close();

            return ms.ToArray();
        }
    }

    public byte[] GenerateEventDetailPdf(Event evt)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            PdfWriter writer = new PdfWriter(ms);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Title
            Paragraph title = new Paragraph(evt.Title)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(24);
            document.Add(title);

            // Event details
            document.Add(new Paragraph($"Date: {evt.EventDate:dd/MM/yyyy HH:mm}"));
            document.Add(new Paragraph($"Lieu: {evt.Location}"));
            document.Add(new Paragraph($"Nombre maximum de participants: {evt.MaxParticipants}"));
            document.Add(new Paragraph("Description:").SetFontSize(14));
            document.Add(new Paragraph(evt.Description));

            document.Close();
            return ms.ToArray();
        }
    }
}