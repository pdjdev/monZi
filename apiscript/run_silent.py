from urllib import parse
from urllib.request import urlopen
from bs4 import BeautifulSoup
from datetime import datetime
import time, lxml

sidoList = {'서울', '부산', '대구', '인천', '광주', '대전', '울산', '경기', '강원', '충북', '충남', '전북', '전남', '경북', '경남', '제주', '세종'}
saveLocation = "/var/www/html/monzi/update/stations/"
getRange = 100
serviceKey = ''

while(1):

    if(datetime.now().minute > 20):
        while(datetime.now().minute > 20):
            time.sleep(0.8)
    time.sleep(180)

    for name in sidoList:
        try:
            sidoName = parse.quote(name)
            time.sleep(0.1)

            url = 'http://openapi.airkorea.or.kr/openapi/services/rest/ArpltnInforInqireSvc/getCtprvnRltmMesureDnsty?ServiceKey='+serviceKey+'&numOfRows='+str(getRange)+'&pageNo=1&sidoName='+sidoName+'&ver=1.3'
            body = urlopen(url).read()
            soup = BeautifulSoup(body, 'lxml-xml')
            infotext = ''

            for air in soup.find_all("item"):
                infotext = '<?xml version="1.0" encoding="utf-8" ?>\n<response>' #+ str(air)
                
                sName = air.find('stationName')
                sMang = air.find('mangName')
                sTime = air.find('dataTime')
                pm10 = air.find('pm10Value')
                pm25 = air.find('pm25Value')

                infotext += str(sName) + '\n' + str(sMang) + '\n' + str(sTime) + '\n' + str(pm10) + '\n' + str(pm25) + '\n</response>'
                f = open(saveLocation + "/" + sName.text + ".xml", 'w')

                f.write(infotext)
                f.close()            
        except: None
            
        time.sleep(0.1)
            
                




