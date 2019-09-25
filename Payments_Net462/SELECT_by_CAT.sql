SELECT TOP 100 CASE
WHEN CatogoryId = 1 THEN 'CSH' WHEN CatogoryId = 2 THEN 'ALF' WHEN CatogoryId = 3 THEN 'PRV' WHEN CatogoryId = 4 THEN 'CEX' 
WHEN CatogoryId = 5 THEN 'WOK' WHEN CatogoryId = 6 THEN 'STU' WHEN CatogoryId = 7 THEN 'HOM' WHEN CatogoryId = 8 THEN 'KID' 
WHEN CatogoryId = 9 THEN 'KIU' WHEN CatogoryId = 10 THEN 'QVN' WHEN CatogoryId = 11 THEN 'FOO' WHEN CatogoryId = 12 THEN 'COF' 
WHEN CatogoryId = 13 THEN 'HLS' WHEN CatogoryId = 14 THEN 'CLO' WHEN CatogoryId = 15 THEN 'VIH' WHEN CatogoryId = 16 THEN 'ENJ' 
WHEN CatogoryId = 17 THEN 'PEB' WHEN CatogoryId = 18 THEN 'VLG' WHEN CatogoryId = 19 THEN 'KSH' WHEN CatogoryId = 43 THEN 'BMO'
ELSE '---' END
CatogoryId,Amount,Description,ID,PayDate FROM [Payments] WHERE PayDate >= '2018-10-01' ORDER BY PayDate DESC

-- ANOTHER REQUEST :
SELECT CatogoryId,Amount,Description,PayDate FROM [Payments] WHERE PayDate>='2018-06-15' AND CatogoryId=1 AND Description LIKE '%profit%' ORDER BY PayDate DESC