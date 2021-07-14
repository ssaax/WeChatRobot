# WeChatRobot
### 微信机器人 C#桌面端

以下为基本设想：
该项目由4部分组成
1. C#桌面端 （主要用于微信挂机收发信息 只提供基础功能服务，将收到的新信息发送给服务器端，由服务器端处理内容，发送也是由服务器端来命令发送）
2. php服务器端（主要处理H5前端互交和桌面端相互的数据交换，将桌面端传入的信息进行”云“处理 以及需要对微信客户端进行的操作都由服务器端发送指令）
3. HTML5互交前端（与服务器端保持websocket连接，显示用户互交界面和数据，前端不做任何数据处理，仅根据服务器端返回的内容进行内容展示。互交操作或数据提交必须进行严格sha1验证）
4. 后台，用于管理指令处理，微信用户授权，对接不同服务或多站点隔离管理 日志查看等。 

作者邮箱：yeahoh@foxmail.com

有空搞一搞，原本是作为一个工作应聘的作品，因为涉及到全栈工作，对个人能力是一个综合性的展现。
该项目主要需要以下技术功底：
1. 汇编 逆向
2. C# 桌面端 和 类库DLL
3. PHP 及 PHP TCP长连接服务器端
4. MySQL 大数据查询优化及数据库设计能力
5. HTML5 前端CSS3.0 JS JQ VUE 这些就不说了

#### 实用性：
1. 登录：网页或APP登录 用户不再需要输入账号密码，将显示几位数字 若干秒刷新一次，将数字发送给所添加的微信号（机器人）即完成登录或自动注册。
2. 收款：用户向任意微信号（机器人）转账任意金额，网页或APP秒到账显示余额。
3. 不再被封：因获取的是原始wxid 是不会变动的，解决公众号授权的痛点，机器人可以是一个微信号 也可以是一万个微信号，向任意一个机器人发送指令或转账都是一样的。
4. 注意事项：为防止出现假机器人收款，应提示用户转帐前确认机器人是否真实，例如发送付款页面上所显示的验证码数字 用户发送后 显示绿码即可确认。

目前支持最新版微信：3.3.0.115
交流QQ群：321795705
