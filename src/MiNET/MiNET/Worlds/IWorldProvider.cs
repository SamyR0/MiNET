﻿using MiNET.Utils;

namespace MiNET.Worlds
{
	public interface IWorldProvider
	{
		bool IsCaching { get; }

		void Initialize();

		ChunkColumn GenerateChunkColumn(ChunkCoordinates chunkCoordinates);

		Vector3 GetSpawnPoint();

		void SaveChunks();
	}
}