# -*- coding:utf-8 -*-
import sys
def baidu_trans():
    global from_data
    while True:
        num=int(input("ѡ��Ҫ���������:1:��/Ӣ  2:Ӣ/��  3:�˳�"))
        word = input("����Ҫ����Ĵ���:")
        if num == 1:
            from_data = {
                "from": "zh",
                "to": "en",
                "query": word,
                "transtype":"realtime",
				"simple_means_flag":"3",
            }
        elif num == 2:
            from_data = {
                "from": "en",
				"to": "zh",
                "query": word,
				"transtype": "realtime",
                "simple_means_flag": "3",
            }
        elif num == 3:
            break
        else:
            print("����������������!")
        url="http://fanyi.baidu.com/v2transapi"
        headers = {"User-Agent": "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.108 Safari/537.36"}
        data=urllib.parse.urlencode(from_data).encode("utf-8")
        resquest=urllib.request.Request(url,data=data,headers=headers)
        response=urllib.request.urlopen(resquest)
        html=response.read().decode("utf-8")
        target=json.loads(html)
        tgt=target['trans_result']['data'][0]['dst']
        print("�����������:%s,\t����Ľ���ǣ�%s----���԰ٶȷ���!"%(word,tgt))