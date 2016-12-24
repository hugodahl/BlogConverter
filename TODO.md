# TODO LIST #


## Cleanup/Refactoring/Rework ##

* Regenerate the BlogML class from the XSD
* Create an encapsulation (wrapper) for the generated class
	  * This encapsulation should be in a more or less "native" format, with the classes decorated with the appropriate custom attributes.


## Functionality to be added/implemented ##

* Create a parser for the BlogML format, in the `BlogConverter.Parsers` project  
    * This should be fairly simple. Encapsulate the XML serializer
* Create a "Writer" project (`BlogConverter.Writers`) in order to output files in the correct format
    * Also include/create a stub for XMLRPC writer.
    * This is where the "output" should happen, so APIs can live here as well.


## Design thoughts ##

* Make the `BlogConverter.Parsers.BlogML` class abstract?
    * This means we could have a "DotNetBlogEngine" parser which can handle DNBE specific items/values which would be in the `AdditionalProperties`
        * This may be where "Tags" live
    * Keep it non-abstract, but allow derivatives? This may help for simpler exports, while still allowing for specific additional properties.

## Other random notes... ##

