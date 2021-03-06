﻿using System;
using System.Collections.Generic;

namespace BoardGamer.BoardGameGeek.BoardGameGeekXmlApi2
{
    public class CollectionResponse
    {
        public CollectionResponse(ItemCollection items)
        {
            this.Succeeded = true;
            this.Result = items;
        }

        public ItemCollection Result { get; }
        public bool Succeeded { get; }

        public class ItemCollection : List<Item>
        {
            public ItemCollection(IEnumerable<Item> items)
                : base(items)
            {}

            public DateTimeOffset PublishDate { get; set; }
            public int TotalItems { get; set; }
            public string TermsOfUse { get; set; }
        }

        public class Item
        {
            public string ObjectType { get; set; }
            public int ObjectId { get; set; }
            public string SubType { get; set; }
            public int CollectionId { get; set; }
            public string Name { get; set; }
            public int YearPublished { get; set; }
            public string Image { get; set; }
            public string Thumbnail { get; set; }
            public Stats Stats { get; set; }
            public Status Status { get; set; }
            public int NumPlays { get; set; }
        }

        public class Status
        {
            public bool ForTrade { get; set; }
            public DateTime LastModified { get; set; }
            public bool Owned { get; set; }
            public bool Preordered { get; set; }
            public bool PreviouslyOwned { get; set; }
            public bool Want { get; set; }
            public bool WantToBuy { get; set; }
            public bool WantToPlay { get; set; }
            public bool Wishlist { get; set; }
        }

        public class Stats
        {
            public int MaxPlayers { get; set; }
            public int MaxPlayTime { get; set; }
            public int MinPlayers { get; set; }
            public int MinPlayTime { get; set; }
            public int NumOwned { get; set; }
            public int PlayingTime { get; set; }
            public Rating Rating { get; set; }
        }

        public class Rating
        {
            public int? UsersRated { get; set; }
            public int? Value { get; set; }
            public double Average { get; set; }
            public double BayesAverage { get; set; }
            public double? StandardDeviation { get; set; }
            public int? Median { get; set; }
            public List<Rank> Ranks { get; set; }
        }

        public class Rank
        {
            public string Type { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public string FriendlyName { get; set; }
            public int? Value { get; set; }
            public double? BayesAverage { get; set; }
        }
    }


}