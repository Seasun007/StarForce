using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameFramework.Network;
using UnityGameFramework.Runtime;

namespace StarForce
{
    public class TestNetPanel : MonoBehaviour
    {
        public InputField input;
        public Button sendBtn;
        // Start is called before the first frame update
        void Start()
        {
            sendBtn.onClick.AddListener(OnClickSendBtn);
        }

        void OnClickSendBtn()
        {
            //测试案例而已，不专注性能
            Debug.Log(input.text);

            if (input == null)
            {
                return;
            }
            if (!string.IsNullOrEmpty(input.text))
            {
                INetworkChannel channel = GameEntry.Network.GetNetworkChannel("CG_TC");
                string str = input.text;


                channel.Send(new GFTestMsg() { Message = input.text });
            }

        }
    }



}
