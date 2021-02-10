Project goal
----------------------
The goal of this project was to develop and API test framework, by doing so demonstrates 
the ability to call endpoints and make request via GET and develop unit tests.

Table Of Contents
------------------
1. Project definition of done
2. Framework
3. Class Diagram
4. Testing
5. Sprint Review
6. Sprint Retrospective

Project definition of done
--------------------------
- Able to retrieve and test the Rates returned
- All tests pass
- Clear documentation
- Clear diagrams
- Project delivered within expected timeframe

Framework
---------
*Api Testing project* is a dotnet api testing framework which retrieves api reposenses
from the targeted endpoints. This project focuses on the endpoint *http://data.fixer.io*
which returns a set of rates as well as other aditional information which were requested by the RESTClient.
The response has been used in order to construct unit tests.The tests which have been written test the basic 
attributes of the JSon response such as querying whether rates exists and performing operations on multiple rates. 

Class Diagram
-------------
![alt text](http://SpartaDevelopment/FixerIOwalkthrough/Imgs)

Testing
-------
By using the HTTP method GET and returning up to date *data.fixer* JSon objects I was able to create several unit tests
in order to check whether the call was a HTTP was a success followed by further initial checks that the 
base value is as expected, lastly two tests on the data which compare and check rates. All the test pass. The framework was 
developed such that unit test are easy to construct as the framework has isolated functioanlity which are used when needed.
The FLServices class is where the test code logic resides which simply needs expanding on. 

Sprint Review
-------------

Sprint Retrospective
--------------------