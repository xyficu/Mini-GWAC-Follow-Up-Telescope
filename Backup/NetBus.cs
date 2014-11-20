///////////////////////////////////////////////////////////////////////////////
/******************************************************************************
 * class NetBus : 网络事务总线
 * NetBus管理接收和发送两条总线
 * 1. 发送总线: 用户将网络消息送入总线, 由类线程定时查询总线上是否有数据需要发
 *    送. 若总线上有数据, 则立即发送一条
 * 2. 接收总线: 收到网络消息后, 将其送入接收总线, 由用户线程定时查询总线上是否
 *    有新消息到达, 若有, 则由用户线程工作逻辑响应
 *****************************************************************************/
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace DDMAgent
{
	class NetBus
	{
		// 远程主机IP地址
		private string m_ipRemote = "127.0.0.1";
		// 远程主机端口
		private int m_portRemote = 0;
		// 连接标志
		private bool m_bConnected = false;
		// 错误描述
		private string m_strError = "";

		public NetBus(string ipRemote, int portRemote)
		{
			m_ipRemote		= ipRemote;
			m_portRemote	= portRemote;
			m_bConnected	= false;
		}

		// 查询是否已经建立与远程主机的连接
		public bool IsConnected()
		{
			return m_bConnected;
		}

		/*!
		 *  \fn bool SetConnect(bool bConnect)
		 *  \brief 改变与远程主机的连接状态
		 *  \param[in] bConnect true: 建立连接; false: 断开连接
		 *  \return
		 *  如果操作成功则返回true, 否则返回false
		 **/
		public bool SetConnect(bool bConnect)
		{
			if (bConnect == m_bConnected)
				return true;
			if (bConnect)
				return Connect();
			else
				return DisConnect();
		}

		// 查看错误描述
		public string GetError()
		{
			return m_strError;
		}

		// 建立与远程主机的连接
		private bool Connect()
		{
			return true;
		}

		// 断开与远程主机的连接
		private bool DisConnect()
		{
			return true;
		}
	}
}
