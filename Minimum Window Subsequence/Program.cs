using System;

namespace Minimum_Window_Subsequence
{
		class Program
		{
				static void Main(string[] args)
				{
						string s1 = "xaymbazbdceabe";
						string s2 = "abe";
						Console.WriteLine(MinWindow(s1, s2));
				}

				// https://www.youtube.com/watch?v=W2DvQcDPD9A
				// https://github.com/shehabic/java-algorithms/blob/master/src/solutions/MinWindowSubSequence.java
				// https://leetcode.com/problems/minimum-window-subsequence/
				/// <summary>
				/// 
				/// </summary>
				/// <param name="s1"></param>
				/// <param name="s2"></param>
				/// <returns></returns>
				public static string MinWindow(string s1, string s2)
				{
						string output = "";
						int j = 0, min = s1.Length + 1;
						for(int i = 0; i < s1.Length; i++)
						{
								if(s1[i] == s2[j])
								{
										j++;
										if (j >= s2.Length)
										{
												int end = i + 1;
												j--;
												while (j >= 0)
												{
														if (s1[i] == s2[j]) j--;
														i--;
												}
												j++;
												i++;
												if (end - i < min)
												{
														min = end - i;
														output = s1.Substring(i, min);
												}
										}
								}
						}

						return output;
				}
		}
}
