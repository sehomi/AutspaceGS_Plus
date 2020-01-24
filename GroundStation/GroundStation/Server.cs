using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundStation_Mahsa
{
    public class LOCATION
    {
        public double lat = 0;
        public double lng = 0;
        public float alt = 0;
        public float climbRate = 0;
        public float hSpeed = 0;
        public float vSpeed = 0;
    }

    public class Server
    {

        public LOCATION location;

        private List<byte> data_packet;
        private int packet_length;
        private int packet_counter;
        public int ackfail;

        public Server()
        {
            location = new LOCATION();
            data_packet = new List<byte>();
            packet_length = 0;
            packet_counter = 0;
            ackfail = 0;
        }

        public void make_buffer(List<byte> received_data)
        {
            byte temp_byte = new byte();
            byte[] check_sums = new byte[2];
            byte[] received_data_bytes = received_data.ToArray();

            for (int j = 0; j < received_data_bytes.Length; j++)
            {
                temp_byte = (byte)received_data_bytes[j];

                if (packet_counter == 1)
                {
                    packet_length = temp_byte;
                    data_packet.Add(temp_byte);
                    packet_counter++;
                    continue;
                }

                if (packet_counter == packet_length - 1)
                {
                    data_packet.Add(temp_byte);
                    packet_counter++;

                    check_sums[0] = (byte)0;
                    check_sums[1] = (byte)0;

                    for (int i = 0; i < packet_length - 2; i++)
                    {
                        check_sums[0] += data_packet[i];
                        check_sums[1] += check_sums[0];
                    }

                    if (data_packet.Count == packet_length && check_sums[0] == data_packet[packet_length - 2] && check_sums[1] == data_packet[packet_length - 1])
                    {
                        Parameter_extract(data_packet.ToArray());
                    }
                    else
                    {
                        ackfail++;
                    }

                    continue;
                }

                if (packet_counter > 1 && packet_counter < packet_length - 1)
                {
                    data_packet.Add(temp_byte);
                    packet_counter++;
                    continue;
                }

                if (temp_byte == 153)
                {
                    data_packet.Clear();
                    packet_counter = 0;


                    data_packet.Add(temp_byte);
                    packet_counter++;
                    continue;
                }

            }
        }

        private void Parameter_extract(byte[] packet)
        {
            byte[] h_temp = new byte[2];
            byte[] temp = new byte[4];
            byte[] d_temp = new byte[8];
            string[] Desk = new string[100];
            
            switch (packet[2])
            {
                case 75:     //LOCATION Message
                    {
                        d_temp[0] = packet[3];
                        d_temp[1] = packet[4];
                        d_temp[2] = packet[5];
                        d_temp[3] = packet[6];
                        d_temp[4] = packet[7];
                        d_temp[5] = packet[8];
                        d_temp[6] = packet[9];
                        d_temp[7] = packet[10];

                        location.lat = BitConverter.ToUInt32(d_temp, 0) / 1e7;

                        d_temp[0] = packet[11];
                        d_temp[1] = packet[12];
                        d_temp[2] = packet[13];
                        d_temp[3] = packet[14];
                        d_temp[4] = packet[15];
                        d_temp[5] = packet[16];
                        d_temp[6] = packet[17];
                        d_temp[7] = packet[18];

                        location.lng = BitConverter.ToUInt32(d_temp, 0) / 1e7;

                        temp[0] = packet[19];
                        temp[1] = packet[20];
                        temp[2] = packet[21];
                        temp[3] = packet[22];

                        location.alt = BitConverter.ToSingle(temp, 0);

                        temp[0] = packet[23];
                        temp[1] = packet[24];
                        temp[2] = packet[25];
                        temp[3] = packet[26];

                        location.climbRate = BitConverter.ToSingle(temp, 0);

                        temp[0] = packet[27];
                        temp[1] = packet[28];
                        temp[2] = packet[29];
                        temp[3] = packet[30];

                        location.hSpeed = BitConverter.ToSingle(temp, 0);

                        temp[0] = packet[31];
                        temp[1] = packet[32];
                        temp[2] = packet[33];
                        temp[3] = packet[34];

                        location.vSpeed = BitConverter.ToSingle(temp, 0);

                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

    }
}
