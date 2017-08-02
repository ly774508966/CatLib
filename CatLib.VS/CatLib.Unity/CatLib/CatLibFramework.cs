﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System.Collections.Generic;
using UnityEngine;

namespace CatLib.CatLib
{
    /// <summary>
    /// CatLib框架
    /// </summary>
    public sealed class CatLibFramework : MonoBehaviour
    {
        /// <summary>
        /// Unity Awake
        /// </summary>
        public void Awake()
        {
            var gameBox = new UnityApplication(this);
            gameBox.Bootstrap(GetBootstraps());
            gameBox.Init();
        }

        /// <summary>
        /// 获取引导程序
        /// </summary>
        /// <returns>引导脚本</returns>
        private IBootstrap[] GetBootstraps()
        {
            var bootstraps = new List<IBootstrap>();
            bootstraps.AddRange(GetComponents<IBootstrap>());
            bootstraps.AddRange(Bootstrap.ServiceBootstraps);
            return bootstraps.ToArray();
        }
    }
}