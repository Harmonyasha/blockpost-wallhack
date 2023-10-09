using Boo.Lang;
using static TestMod.Utility.Log;
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Threading;
using MelonLoader;
using System.Threading.Tasks;
using Mono.CSharp;

namespace TestMod.CustomEvent
{
   

     class ObjectAdded
    {
        public static List ids = new List();
        public static List objtable = new List();
        public static async Task UpdateAsync()
        {
            await Task.Run(() => MelonCoroutines.Start(update()));
        }
        public static IEnumerator update()
        {
            //GameObject[] allObjects = Resources.FindObjectsOfTypeAll<GameObject>();
            while (true)
            {
                Msg("loop");
                

                foreach (GameObject v in Resources.FindObjectsOfTypeAll<GameObject>())
                {
                    if (ids.Contains(v.GetInstanceID()) == false)
                    {
                        yield return new WaitForSeconds(.01f);
                        try
                        {
                            
                            ids.Add(v.GetInstanceID());
                            objtable.Add(new List() { v, v.name });
                            //    Msg($"Added {v.name}");
                        }catch {}

                    }

                }
                int i = 0;
                List remove = new List();
                
                foreach (int v in ids)
                {
                    i++;

                    Object obj = GameObject.FindObjectFromInstanceID(v);
                    if (obj == null)
                    {
                        yield return new WaitForSeconds(.01f);
                       
                        try
                        {
                            List obje = (List)objtable[i];
                            //    Msg($"Object removed {obje[1]} ");
                            remove.Add(i);
                        }
                        catch {}

                    }
                    }

                foreach (int d in remove)
                {
                    yield return new WaitForSeconds(.01f);
                    try
                    {
                        ids.RemoveAt(d);
                        objtable.RemoveAt(d);
                    }
                    catch { Msg("Error"); }
                }

                yield return new WaitForSeconds(.1f);
            }

            
        }
        }


    }

