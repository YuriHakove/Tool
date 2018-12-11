# -*- coding:utf-8 -*-
import urllib.request
import urllib.parse
import json
import execjs
import sys

class Py4Js():
    """
    计算谷歌TL值
    """
    def __init__(self):
        self.ctx = execjs.compile("""
        function TL(a) {
        var k = "";
        var b = 406644;
        var b1 = 3293161072;

        var jd = ".";
        var $b = "+-a^+6";
        var Zb = "+-3^+b+-f";

        for (var e = [], f = 0, g = 0; g < a.length; g++) {
            var m = a.charCodeAt(g);
            128 > m ? e[f++] = m : (2048 > m ? e[f++] = m >> 6 | 192 : (55296 == (m & 64512) && g + 1 < a.length && 56320 == (a.charCodeAt(g + 1) & 64512) ? (m = 65536 + ((m & 1023) << 10) + (a.charCodeAt(++g) & 1023),
            e[f++] = m >> 18 | 240,
            e[f++] = m >> 12 & 63 | 128) : e[f++] = m >> 12 | 224,
            e[f++] = m >> 6 & 63 | 128),
            e[f++] = m & 63 | 128)
        }
        a = b;
        for (f = 0; f < e.length; f++) a += e[f],
        a = RL(a, $b);
        a = RL(a, Zb);
        a ^= b1 || 0;
        0 > a && (a = (a & 2147483647) + 2147483648);
        a %= 1E6;
        return a.toString() + jd + (a ^ b)
    };

    function RL(a, b) {
        var t = "a";
        var Yb = "+";
        for (var c = 0; c < b.length - 2; c += 3) {
            var d = b.charAt(c + 2),
            d = d >= t ? d.charCodeAt(0) - 87 : Number(d),
            d = b.charAt(c + 1) == Yb ? a >>> d: a << d;
            a = b.charAt(c) == Yb ? a + d & 4294967295 : a ^ d
        }
        return a
    }
    """)

    def getTk(self, text):
        """
        获取TK
        :param text:
        :return:
        """
        return self.ctx.call("TL", text)


def youdao_trans():
    """
    有道翻译
    :return:
    """
    word = input("输入要翻译的词语:")
    # 有道词典查询的参数
    from_data = {
        "i": word,
        "from": "AUTO",
        "to": "AUTO",
        "smartresult": "dict",
        "client": "fanyideskweb",
        # "salt":"1513951947656",
        # "sign":"3f8069a4d406571ae4d4e9e51851ff09",
        "doctype": "json",
        "version": "2.1",
        "keyfrom": "fanyi.web",
        "action": "FY_BY_REALTIME",
        "typOresult": "false"
    }
    # 报头
    headers = {"User-Agent": "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.108 Safari/537.36"}
    # 有道翻译url
    url = "http://fanyi.youdao.com/translate?smartresult=dict&smartresult=rule"
    # 把字典转成url的编码
    data = urllib.parse.urlencode(from_data).encode("utf-8")
    # 构造发送请求
    # 如果有data参数,那么从默认的get请求变为post请求,如果没有data参数,就是iget请求
    request = urllib.request.Request(url,data=data,headers=headers)
    # 发送响应请求,并返回响应对象
    response = urllib.request.urlopen(request)
    # 返回字符串并去除空格
    str_deal = response.read().strip().decode("utf-8")
    # 将字符串中的"字典"转成真正的字典
    #tgt=json.dumps(str_deal)
    str_deal = eval(str_deal)
    # {"type":"ZH_CN2EN","errorCode":0,"elapsedTime":1,"translateResult":[[{"src":"世界","tgt":"The world"}]]}
    # 字符串处理,去除前后空格
    print("输入的内容是:%s\t翻译的结果是:%s---来自有道词典!"%(word,str_deal["translateResult"][0][0]["tgt"]))

def baidu_trans():
    """
    百度翻译
    global:全局变量
    :return:
    """
    global from_data
    while True:
       """ num=int(input("选择要翻译的类型:1:中/英  2:英/中  3:退出"))"""
	#num=1
       """word = input("输入要翻译的词语:")'
       # word="你好，世界。"
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
        #把字典转成url编码
        data=urllib.parse.urlencode(from_data).encode("utf-8")
        #发送请求
        resquest=urllib.request.Request(url,data=data,headers=headers)
        #返回响应对象
        response=urllib.request.urlopen(resquest)
        #读取响应对象字符串
        html=response.read().decode("utf-8")
        #通过json处理返回的字符串的编码,并转成可用的字典
        target=json.loads(html)
        tgt=target['trans_result']['data'][0]['dst']
        print("输入的内容是:%s,\t翻译的结果是：%s----来自百度翻译!"%(word,tgt))
def google_trans():
    """
    谷歌翻译
    num:输入的功能
    word:保存输入的字符串
    data:保存输入word的url编码
    tk:保存谷歌的tk码
    fullurl:完整的url地址

    :return:
    """
    global fullurl
    while True:
        num=int(input("选择要翻译的类型:1:中/英  2:英/中  3:退出"))
        # 创建Py4Js对象
        js = Py4Js()
        word = input("输入要翻译的词语:")
        #输入的字符不能超过4891
        try:
            if len(word)>4891:
                print("翻译的长度超过限制!")
                return
        except Exception as e:
            pass
        # 把查询的词转成url编码
        data = urllib.parse.quote(word)
        # 获取谷歌tk码
        tk = js.getTk(word)
        if num == 1:
            # https://translate.google.cn/translate_a/single?client=t&sl=auto&tl=en&hl=zh-CN&dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw&dt=rm&dt=ss&dt=t&ie=UTF-8&oe=UTF-8&source=bh&ssel=0&tsel=0&kc=1&tk=942945.526772&q=%E5%8F%91%E5%91%86
            #中/英url地址
            fullurl="https://translate.google.cn/translate_a/" \
                "single?client=t&sl=auto&tl=en&hl=zh-CN&" \
                "dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw" \
                "&dt=rm&dt=ss&dt=t&ie=UTF-8&oe=UTF-8&source=bh" \
                "&ssel=0&tsel=0&kc=1&tk=%s&q=%s"%(tk,data)

        elif num == 2:
            # 英/中url地址
            fullurl="https://translate.google.cn/translate_a/" \
                  "single?client=t&sl=en&tl=zh-CN&hl=zh-CN&" \
                  "dt=at&dt=bd&dt=ex&dt=ld&dt=md&dt=qca&dt=rw" \
                  "&dt=rm&dt=ss&dt=t&ie=UTF-8&oe=UTF-8&source=bh" \
                  "&ssel=0&tsel=0&kc=1&tk=%s&q=%s" % (tk, data)
        elif num ==3:
            break
        else:
            print("输入有误重新输入!")
        #请求报头
        headers = {"User-Agent": "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.108 Safari/537.36"}
        #发送请求
        resquest=urllib.request.Request(fullurl,headers=headers)
        #返回响应对象
        response=urllib.request.urlopen(resquest)
        #读取响应对象字符串
        html=response.read().decode("utf-8")
        #切片,获取翻译后的字符
        # end = html.find("\",")
        # if end > 4:
        #     html=html[4:end]
        # 通过json处理返回的字符串的编码,并转成可用的字典
        html=json.loads(html)
        print("输入的内容是:%s,\t翻译的结果是：%s----来自谷歌翻译!" % (word, html[0][0][0]))
def print_menu():
    """
    打印主菜单
    :return:
    """
    print("简易词典v1.0 ")
    print("           ----by豆瓣酱")
    print("1.谷歌翻译-推荐使用")
    print("2.百度翻译")
    print("3.有道词典")
    print("4.退出")
def get_path():
    """
    获取导入摸块的路径
    :return:
    """
    print(sys.modules["urllib.request"])
    print(sys.modules["urllib.parse"])
    print(sys.modules["execjs"])
    print(sys.modules["json"])
    print(sys.modules["sys"])

  """
from_data={}
if __name__ == '__main__':
    get_path()
    print_menu()
    num=int(input("选择使用的词典:"))
    if num == 1:
        google_trans()
    elif num == 2:
        baidu_trans()
    elif num == 3:
        youdao_trans()
    elif num == 4:
        sys.exit()
    else:
        print("输入有误重新输入!")
   """