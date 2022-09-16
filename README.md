# Automation test For Marketwatch.com
**Skill test in automation testing**
## Setup
Page used for testing: 
[MarketWatch.com](https://www.marketwatch.com/)  

Testing enviorment ▼
- windows 11 
- chrome 
- Visual studio
- c# 
- page object model
- selenium

## Test plan
Search for Bitcoin USD and check if
its 5 days performance rate change was positive.

**Test case 1**  
*Search and Check bitcoin 5 day preformance*  
Expected result - 5 day preformance precentage is positive 
- accept cookies
- click search button (To pop up search input field)
- enter "Bitcoin" to search input field
- click search button (optional)
- click "BTCUSD" in results
- check 5 day preformance

**Test case 2**  
*Find bitcoin through table in the main page and check 5 day preformance*  
Expected result - 5 day preformance precentage is positive 
- accept cookies
- click crypto in table top
- click Bitcoin USD
- check 5 day preformance

