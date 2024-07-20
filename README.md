# ConsoleApp5

ControlUp Technical Exercise

Thank you for the opportunity to work through this exercise, although I found it challenging it was very enjoyable. 
I want to state that prior to working through the exercise I had no knowledge of C#, therefore what I have put together was a culmination of my efforts to learn and understand how I can achieve the required result.

The Exercise

-	Create a backend automation framework in C# for the following API endpoint
o	https://rapidapi.com/DataCrawler/api/tripadvisor16/
-	Create a unit test that will print out cruises with destination “Caribbean” and sort them by number of crew.
-	Query ‘Get Cruises Location’ endpoint to get destinationId for Caribbean
-	Use the destinationId in ‘Search Cruises’ endpoint call to print out all ship names and sort the records in descending order by number of crew

Workings

The first thing I did was setup Visual Studio. After that I installed Postman as a way for me to quickly interact with the API.
I ran a quick HTTP Get against the provided address but soon realised that was not going to provide me with the information I needed, and so went directly to the address. From here I was able to find the two API calls I would need to collect the relevant data, these were
1.	https://tripadvisor16.p.rapidapi.com/api/v1/cruises/getLocation
2.	https://tripadvisor16.p.rapidapi.com/api/v1/cruises/searchCruises?destinationId=xxxxxx

   
I used Postman to quey “getLocation” but this failed due to the missing API Key and value, however, after quickly revisiting the API address and I was able to obtain these by signing up.
With the API Key and value, I was now able to run a GET and review the JSON to find the “destinationid” for Caribbean cruises, which was 147237.

I would then input this into the second API and search all cruises which had the destinationid for Caribbean.

With this information I could begin to research how to make API calls using C#. I began as all IT Professionals do, with Google, this lead me here: 
•	https://learn.microsoft.com/en-us/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client

Reading through the webpage I determined I would need to use the HttpClient Class to create the GET request. This led me here: 
•	https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient

Unfortunately, I wasn’t able to get anywhere with this approach and felt I needed something simpler. 

Further research led me to an educational video on YouTube – from here I was able to put together a basic GET request, but I had forgotten about the API Key (See image 1).
After updating the request with the request headers, I was able to bring back some results, this is what I had ended up with (See image 2).

The problem I faced at this point was retrieving the specific data from the JSON file and organising it. I discovered this could be done by deserializing the JSON and then printing the results.
With some help from ChatGPT, I ended up with this (Image 3). Unfortunately, this was failing as I need to use an array for the JSON. After several attempts at trying to get the JSON response to be an array, I had hit my monthly request quota for the API endpoint.

Although I couldn’t achieve the desired results, it was an enjoyable task and I learnt a lot from it, it’s also made me want to continue learning C#. I spent roughly 6 hours on the task, and all things considered I’m happy with what I was able to achieve in that time.

I’m not entirely sure what your expectations are for me in this role, however being honest, if you’re after someone to jump in and already be able to build these types of frameworks in C#, sadly I’m not there yet. But, if you’re looking for someone who is ambitious and who can develop into the role, that is something I can do.
