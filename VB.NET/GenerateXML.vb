Imports System.xml

Module GenerateXML
   Sub Main
       Dim Writer As New XMLTextWriter("Employee.xml",System.Text.Encoding.UTF8)
       Writer.WriteStartDocument()
       Writer.Formatting= Formatting.Indented
       writer.writeStartElement("Employee")
       Writer.WriteStartElement("Row")
       Writer.WritestartElement("Id")
       Writer.WriteString("E001")
       Writer.WriteEndElement()
       Writer.WriteStartElement("Name")
       Writer.WriteString("Neha Bharti")
       Writer.writeEndElement()
       Writer.WriteStartElement("Location")
       Writer.WriteString("Muzaffarpur")
       Writer.WriteEndElement()
       Writer.WriteEndElement()

       Writer.WritestartElement("row")
       Writer.WritestartElement("Id")
       Writer.WriteString("E002")
       Writer.WriteEndElement()
       Writer.WriteStartElement("Name")
       Writer.WriteString("Tanishaka Bharti")
       Writer.WriteEndElement()
       Writer.WriteStartElement("Location")
       Writer.WriteString("Muzaffarpur")
       Writer.WriteEndElement()
       writer.WriteEndElement()

       Writer.WriteStartElement("row")
       Writer.WriteStartElement("id")
       Writer.WriteString("E002")
       Writer.WriteEndElement()
       Writer.WriteStartElement("name")
       Writer.WriteString("Simran Kumari")
       Writer.WriteEndElement()
       writer.WriteStartElement("location")
       Writer.WriteString("Muzaffarpur")
       Writer.WriteEndElement()

       Writer.WriteStartElement("row")
       Writer.WriteStartElement("id")
       Writer.WriteString("E004")
       Writer.WriteEndElement()
       Writer.WriteStartElement("name")
       Writer.WriteString("Prince Kumar")
       Writer.WriteEndElement()
       writer.WriteStartElement("location")
       Writer.WriteString("Muzaffarpur")
       Writer.WriteEndElement()

       Writer.WriteStartElement("row")
       Writer.WriteStartElement("id")
       Writer.WriteString("E005")
       Writer.WriteEndElement()
       Writer.WriteStartElement("name")
       Writer.WriteString("Payal Kumari")
       Writer.WriteEndElement()
       writer.WriteStartElement("location")
       Writer.WriteString("Muzaffarpur")
       Writer.WriteEndElement()
       Writer.WriteEndElement()
       Writer.WriteEndElement()
       Writer.close()
    End Sub  
End Module     
