Created an Interface IDataProcessor which has a "Process" method. This is implemented by three classes BinaryDataProcessor, TextDataProcessor and TextReverseDataProcessor 

Created an Enum which defines the three Data types - Binary, Text and TextReverse.

Created a ServiceProvider Class to select the appropriate processor based on datatype. 

Created another Interface IDataFetcher that has a "Fetch" Method. This is implemented currently by a FileDataFetcher class. More sources like database or eventlog can be added similarly.

The Main Program expects two input arguments - Filepath and Datatype. Example are shown below :

C:\Docutech\temp.txt Binary
C:\Docutech\temp.txt Text
C:\Docutech\temp.txt TextReverse

Using filepath parameter we fetch the rawdata and process the same using the appropriate dataprocessor. 
Finally we print first five bytes of processed data.

