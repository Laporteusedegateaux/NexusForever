namespace NexusForever.Network.World.Entity.Command
{
    [EntityCommand(EntityCommand.SetPosition)]
    public class SetPositionCommand : IEntityCommandModel
    {
        public Position Position { get; set; }
        public bool Blend { get; set; }

        public void Read(GamePacketReader reader)
        {
            Position = new Position();
            Position.Read(reader);
            Blend = reader.ReadBit();
        }

        public void Write(GamePacketWriter writer)
        {
            Position.Write(writer);
            writer.Write(Blend);
        }
    }
}