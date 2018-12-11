# -*- coding:utf-8 -*-
import sys
def baidu_trans():
    global from_data
    while True:
        num=int(input("选择要翻译的类型:1:中/英  2:英/中  3:退出"))
        word = input("输入要翻译的词语:")
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
            print("输入有误重新输入!")
        url="http://fanyi.baidu.com/v2transapi"
        headers = {"User-Agent": "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.108 Safari/537.36"}
        data=urllib.parse.urlencode(from_data).encode("utf-8")
        resquest=urllib.request.Request(url,data=data,headers=headers)
        response=urllib.request.urlopen(resquest)
        html=response.read().decode("utf-8")
        target=json.loads(html)
        tgt=target['trans_result']['data'][0]['dst']
        print("输入的内容是:%s,\t翻译的结果是：%s----来自百度翻译!"%(word,tgt))
