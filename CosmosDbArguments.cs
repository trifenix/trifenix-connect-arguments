﻿using System.Collections.Generic;

namespace trifenix.connect.arguments
{

    /// <summary>
    /// Argumentos de cosmosDb
    /// </summary>
    public class CosmosDbArguments {
        /// <summary>
        /// EndPoint of the db
        /// </summary>
        /// <value>
        /// The end point URL.
        /// </value>
        public string EndPointUrl { get; set; }

        /// <summary>
        /// the cosmos db primary key
        /// </summary>
        /// <value>
        /// The primary key.
        /// </value>
        public string PrimaryKey { get; set; }


        /// <summary>
        /// Gets or sets the name of the cosmos database.
        /// </summary>
        /// <value>
        /// The name database.
        /// </value>
        public string NameDb { get; set; }

        /// <summary>
        /// Gets or sets the Containers of the cosmos dataBase.
        /// <value>
        /// List of containers
        /// </value>
        /// </summary>
        public List<ContainerInfo> Containers { get; set; }

                      
    }
    /// <summary>
    /// Class of containerInfo
    /// </summary>
    public class ContainerInfo
    {
        /// <summary>
        /// Name of container
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PartitionKey of container
        /// </summary>
        public string PartitionKey { get; set; }
    }
}