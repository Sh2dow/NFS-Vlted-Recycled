using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace VaultEditor;

public sealed class GClass38 : IDisposable
{
    private sealed class Stream2(Stream stream_1) : Stream
    {
        private readonly Stream stream_0 = stream_1;

        private uint uint_0 = uint.MaxValue;

        public override bool CanRead => true;

        public override bool CanSeek => false;

        public override bool CanWrite => false;

        public override long Length
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        public override long Position
        {
            get
            {
                throw new InvalidOperationException();
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        public GStruct0 method_0()
        {
            return new GStruct0((int)Class14.smethod_1(uint_0));
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int num = stream_0.Read(buffer, offset, count);
            for (int i = 0; i < num; i++)
            {
                uint_0 = Class14.smethod_2(uint_0, buffer[offset + i]);
            }
            return num;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new InvalidOperationException();
        }

        public override void SetLength(long value)
        {
            throw new InvalidOperationException();
        }

        public override void Flush()
        {
            throw new InvalidOperationException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new InvalidOperationException();
        }
    }

    [CompilerGenerated]
    private sealed class Class47
    {
        public GClass38 gclass38_0;

        public Stream stream_0;

        public bool bool_0;

        internal GStruct7 method_0()
        {
            lock (gclass38_0.object_0)
            {
                if (gclass38_0.stream_0 != null)
                {
                    throw new InvalidOperationException();
                }
                gclass38_0.stream_0 = stream_0;
                gclass38_0.long_0 = 0L;
                Monitor.PulseAll(gclass38_0.object_0);
                while (gclass38_0.stream_0 != null)
                {
                    Monitor.Wait(gclass38_0.object_0);
                }
                GStruct0? nullable_ = (bool_0 ? new GStruct0?(((Stream2)stream_0).method_0()) : ((GStruct0?)null));
                gclass38_0.ilist_0.Add(new GStruct2(gclass38_0.long_0, nullable_));
                return new GStruct7(gclass38_0.long_0, nullable_);
            }
        }
    }

    private readonly object object_0 = new();

    private readonly GClass24 gclass24_0;

    private readonly GClass29 gclass29_0;

    private readonly Class39 class39_0;

    private readonly Class40[] class40_0;

    private readonly Class41[] class41_0;

    private readonly Class42[] class42_0;

    private readonly IList<GStruct2> ilist_0 = [];

    private Stream stream_0;

    private long long_0;

    private readonly int int_0;

    private bool bool_0;

    private bool bool_1;

    internal GClass38(GClass24 gclass24_1, int int_1, GClass29 gclass29_1, Class39 class39_1, Class40[] class40_1, Class41[] class41_1, Class42[] class42_1)
    {
        gclass24_0 = gclass24_1;
        int_0 = int_1;
        gclass29_0 = gclass29_1;
        class39_0 = class39_1;
        class40_0 = class40_1;
        class41_0 = class41_1;
        class42_0 = class42_1;
        class39_1.method_0(this);
    }

    public void Dispose()
    {
        Class42[] array = class42_0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i].Dispose();
        }
        Class41[] array2 = class41_0;
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i]?.method_0();
        }
        Class40[] array3 = class40_0;
        for (int i = 0; i < array3.Length; i++)
        {
            array3[i].method_0();
        }
        class39_0.method_1();
    }

    internal async Task<int> method_0(byte[] byte_0, int int_1, int int_2, GEnum2 genum2_0)
    {
        Stream stream;
        lock (object_0)
        {
            while (stream_0 == null)
            {
                if (!bool_0)
                {
                    Monitor.Wait(object_0);
                    continue;
                }
                bool_1 = true;
                Monitor.PulseAll(object_0);
                return 0;
            }
            stream = stream_0;
        }
        int num = 0;
        while (true)
        {
            int num2 = await stream.ReadAsync(byte_0, int_1, int_2).ConfigureAwait(continueOnCapturedContext: false);
            if (num2 < 0 || num2 > int_2)
            {
                break;
            }
            num += num2;
            int_1 += num2;
            int_2 -= num2;
            long_0 += num2;
            if (num2 > 0)
            {
                if (genum2_0 == GEnum2.const_1 || int_2 == 0)
                {
                    return num;
                }
                continue;
            }
            lock (object_0)
            {
                if (stream_0 != stream)
                {
                    throw new Exception1();
                }
                stream_0 = null;
                Monitor.PulseAll(object_0);
                while (stream_0 == null)
                {
                    if (!bool_0)
                    {
                        Monitor.Wait(object_0);
                        continue;
                    }
                    bool_1 = true;
                    Monitor.PulseAll(object_0);
                    return num;
                }
                stream = stream_0;
            }
        }
        throw new InvalidOperationException("Source stream violated stream contract.");
    }

    public async Task method_1()
    {
        lock (object_0)
        {
            if (bool_0)
            {
                throw new InvalidOperationException();
            }
            bool_0 = true;
            Monitor.PulseAll(object_0);
            while (!bool_1)
            {
                Monitor.Wait(object_0);
            }
        }
        Class40[] array = class40_0;
        for (int i = 0; i < array.Length; i++)
        {
            await array[i].method_6().ConfigureAwait(continueOnCapturedContext: false);
        }
        int num = 0;
        int[] array2 = new int[class42_0.Length];
        for (int j = 0; j < class42_0.Length; j++)
        {
            array2[j] = num;
            num += gclass29_0.method_0(j).Int32_0;
        }
        List<GClass14> list = [];
        for (int k = 0; k < class42_0.Length; k++)
        {
            GClass35 gClass = gclass29_0.method_0(k);
            GClass30 settings = gClass.Settings;
            GStruct6 gstruct6_ = settings.vmethod_0();
            int num2 = gstruct6_.method_2();
            List<GStruct4> list2 = [];
            for (int l = 0; l < num2; l++)
            {
                GClass36 target = gClass.method_1(l).Target;
                if (target.Boolean_0)
                {
                    list2.Add(new GStruct4(null, target.Index));
                }
                else
                {
                    list2.Add(new GStruct4(target.Node.Index, target.Index));
                }
            }
            int num3 = gstruct6_.method_3();
            List<GStruct5> list3 = [];
            for (int m = 0; m < num3; m++)
            {
                if (gClass.method_0(m).Source.Boolean_0)
                {
                    list3.Add(new GStruct5(class39_0.method_2()));
                }
                else
                {
                    list3.Add(new GStruct5(class41_0[array2[k] + m].method_1()));
                }
            }
            list.Add(new GClass14(gstruct6_, settings.vmethod_2(), list2, list3));
        }
        GClass36 target2 = gclass29_0.method_2().Target;
        GClass13 gclass13_ = new(list, new GStruct4(target2.Node.Index, target2.Index), class39_0.method_2(), class39_0.method_3(), ilist_0);
        gclass24_0.method_23(this, int_0, gclass13_, class40_0);
    }

    public Task<GStruct7> method_2(Stream stream_1, bool bool_2)
    {
        if (stream_1 == null)
        {
            throw new ArgumentNullException("stream");
        }
        if (bool_2)
        {
            stream_1 = new Stream2(stream_1);
        }
        return Task.Run(delegate
        {
            lock (object_0)
            {
                if (stream_0 != null)
                {
                    throw new InvalidOperationException();
                }
                stream_0 = stream_1;
                long_0 = 0L;
                Monitor.PulseAll(object_0);
                while (stream_0 != null)
                {
                    Monitor.Wait(object_0);
                }
                GStruct0? nullable_ = (bool_2 ? new GStruct0?(((Stream2)stream_1).method_0()) : ((GStruct0?)null));
                ilist_0.Add(new GStruct2(long_0, nullable_));
                return new GStruct7(long_0, nullable_);
            }
        });
    }
}
